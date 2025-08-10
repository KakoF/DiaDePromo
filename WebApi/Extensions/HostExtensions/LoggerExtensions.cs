using Elastic.Ingest.Elasticsearch.DataStreams;
using Elastic.Serilog.Sinks;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Reflection;

namespace WebApi.Extensions.HostExtensions
{
	public static class LoggerExtensions
	{
		public static void AddLogger(this ConfigureHostBuilder host)
		{
			var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

			var configuration = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.AddJsonFile($"appsettings.{environment}.json", optional: true)
				.Build();
			Log.Logger = new LoggerConfiguration()
			.MinimumLevel.Information()
			.Enrich.FromLogContext()
			.WriteTo.Elasticsearch(new[] { new Uri(configuration["ElasticConfiguration:Uri"]!) }, opts => {
				opts.DataStream = new DataStreamName("logs", $"{Assembly.GetExecutingAssembly().GetName().Name!.ToLower().Replace(".", "-")}-{environment!.ToLower()}", $"{DateTime.UtcNow:yyyy-MM}");
			})
			.Enrich.WithProperty("Environment", environment)
			.Enrich.WithProperty("HostName", System.Net.Dns.GetHostName())
			.ReadFrom.Configuration(configuration: configuration)
			.WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] | {Message:lj}{NewLine}{Exception}")
			.CreateLogger();
			host.UseSerilog();
		}
	}
}
