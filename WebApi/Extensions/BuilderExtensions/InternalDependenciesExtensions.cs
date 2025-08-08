using Application.Services;
using Domain.Interfaces.Infrastructure;
using Domain.Interfaces.Services;
using Infrastructure.Storage;

namespace WebApi.Extensions.BuilderExtensions
{
	public static class InternalDependenciesExtensions
	{
		public static void AddInternalDependencies(this IServiceCollection services)
		{
			services.AddScoped<ITabloideService, TabloidService>();
			services.AddScoped<IStorage, Storage>();
		}
	}
}
