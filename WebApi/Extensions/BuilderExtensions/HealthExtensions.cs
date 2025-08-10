using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace WebApi.Extensions.BuilderExtensions
{
	public static class HealthExtensions
	{
		public static void AddHealthChecks(this WebApplicationBuilder builder)
		{

			builder.Services.AddHealthChecks()
			.AddCheck("self", () => HealthCheckResult.Healthy());
		}
	}
}
