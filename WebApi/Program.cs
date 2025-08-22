using Hangfire;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WebApi.Extensions.AppExtensions;
using WebApi.Extensions.BuilderExtensions;
using WebApi.Extensions.HostExtensions;
using WebApi.Helpers;
using WebApi.Job;
using WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore)
  .AddJsonOptions(opt =>
  {
	  opt.JsonSerializerOptions.Converters.Add(new OptOutJsonConverterFactory(new JsonStringEnumConverter()));
  });
builder.Services.AddSwagger();
builder.Services.AddHealthChecks();
builder.Services.AddInternalDependencies();
builder.Services.AddHangfireJob();
builder.AddMongoConfiguration();
builder.Host.AddLogger();

var app = builder.Build();

app.AddSwagger();

app.UseHttpsRedirection();
app.UsePrometheus();
app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseHangfireDashboard();

using (var scope = app.Services.CreateScope())
{
	var jobManager = scope.ServiceProvider.GetRequiredService<IRecurringJobManager>();
	jobManager.AddOrUpdate<DayAnalisys>(
		"analisys-promo-day",
		job => job.ExecuteAsync(),
		"0 10 * * *",
		new RecurringJobOptions
		{
			TimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time")
		}
	);

	jobManager.AddOrUpdate<RemoveExpiredItens>(
		"remove-expired-itens",
		job => job.ExecuteAsync(),
		"0 1 * * *",
		new RecurringJobOptions
		{
			TimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time")
		}
	);
}


app.Run();
