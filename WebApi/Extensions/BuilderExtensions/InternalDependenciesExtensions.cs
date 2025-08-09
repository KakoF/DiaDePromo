using Application.Services;
using Application.UseCases;
using Domain.Interfaces.Application.Services;
using Domain.Interfaces.Application.UseCases;
using Domain.Interfaces.Infrastructure;
using Infrastructure.Storage;

namespace WebApi.Extensions.BuilderExtensions
{
	public static class InternalDependenciesExtensions
	{
		public static void AddInternalDependencies(this IServiceCollection services)
		{
			services.AddScoped<IMarkeUseCase, MarkeUseCase>();
			services.AddScoped<IItemUseCase, ItemUseCase>();
			services.AddScoped<ITabloideService, TabloidService>();
			services.AddScoped<IStorage, Storage>();
		}
	}
}
