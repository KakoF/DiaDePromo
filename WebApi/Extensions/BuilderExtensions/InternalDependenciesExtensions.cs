using Application.Services;
using Application.UseCases;
using Domain.Interfaces.Application.Services;
using Domain.Interfaces.Application.UseCases;
using Domain.Interfaces.Infrastructure;
using Domain.Interfaces.Infrastructure.Extrator;
using Infrastructure.Extrator;
using Infrastructure.Storage;

namespace WebApi.Extensions.BuilderExtensions
{
	public static class InternalDependenciesExtensions
	{
		public static void AddInternalDependencies(this IServiceCollection services)
		{
			services.AddScoped<IMarkeUseCase, MarkeUseCase>();
			services.AddScoped<ITabloideService, TabloidService>();
			services.AddScoped<IStorage, Storage>();
			services.AddScoped<IItensExtrator, ItensExtrator>();
		}
	}
}
