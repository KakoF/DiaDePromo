using Infrastructure.Config;
using Microsoft.Extensions.Options;

namespace WebApi.Extensions.BuilderExtensions
{
	public static class DatabaseExtensions
	{
		public static void AddMongoConfiguration(this WebApplicationBuilder builder)
		{
			builder.Services.Configure<DbSettings>(builder.Configuration.GetSection("MongoDbSettings"));
			builder.Services.AddSingleton(serviceProvider =>
					serviceProvider.GetRequiredService<IOptions<DbSettings>>().Value);
			//Console.WriteLine(builder.Configuration.GetSection("MongoDbSettings:ConnectionString").Value);
		}
	}
}
