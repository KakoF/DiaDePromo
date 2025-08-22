using Hangfire;
using WebApi.Job;

namespace WebApi.Extensions.BuilderExtensions
{
	public static class HangfireExtensions
	{
		public static void AddHangfireJob(this IServiceCollection services)
		{
			services.AddHangfire(config =>
				config.UseInMemoryStorage());

			services.AddHangfireServer();

			services.AddTransient<DayAnalisys>();
			services.AddTransient<RemoveExpiredItens>();

		}
	}
}
