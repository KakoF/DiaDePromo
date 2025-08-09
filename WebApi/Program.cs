using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WebApi.Extensions.AppExtensions;
using WebApi.Extensions.BuilderExtensions;
using WebApi.Extensions.HostExtensions;
using WebApi.Helpers;
using WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore)
  .AddJsonOptions(opt =>
  {
	  opt.JsonSerializerOptions.Converters.Add(new OptOutJsonConverterFactory(new JsonStringEnumConverter()));
  });
builder.Services.AddSwagger();
builder.Services.AddInternalDependencies();

builder.Host.AddLogger();

var app = builder.Build();

app.AddSwagger();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.Run();
