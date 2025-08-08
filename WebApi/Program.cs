using WebApi.Extensions.AppExtensions;
using WebApi.Extensions.BuilderExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwagger();
builder.Services.AddInternalDependencies();

builder.Host.AddLogger();

var app = builder.Build();

app.AddSwagger();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
