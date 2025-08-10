using Microsoft.Extensions.Diagnostics.HealthChecks;
using Prometheus;
using System.Net;

namespace WebApi.Extensions.AppExtensions
{
	public static class UsePrometheusExtensions
	{
		public static void UsePrometheus(this WebApplication app)
		{
			app.UseHealthChecksPrometheusExporter("/metrics", options => options.ResultStatusCodes[HealthStatus.Unhealthy] = (int)HttpStatusCode.OK);
			app.UseHttpMetrics();
		}
	}
}
