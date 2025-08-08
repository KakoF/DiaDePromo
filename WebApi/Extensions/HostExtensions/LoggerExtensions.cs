using Serilog;

namespace WebApi.Extensions.HostExtensions
{
	public static class LoggerExtensions
	{
		public static void AddLogger(this ConfigureHostBuilder host)
		{
			Log.Logger = new LoggerConfiguration()
			.MinimumLevel.Information()
			.Enrich.FromLogContext()
			.WriteTo.Console()
			.WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] | {Message:lj}{NewLine}{Exception}")
			.CreateLogger();
			host.UseSerilog();
		}
	}
}
