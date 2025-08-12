using Application.Services;
using Application.UseCases;
using Domain.Interfaces.Application.Services;
using Domain.Interfaces.Application.UseCases;
using Infrastructure.Context;
using Infrastructure.Entities.Documents;
using Infrastructure.Interfaces.Repositories;
using Infrastructure.Interfaces.Storage;
using Infrastructure.Repositories;
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
			services.AddScoped<ICityUseCase, CityUseCase>();
			services.AddScoped<ICityRepository, CityRepository>();
			services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));
			services.AddScoped<IMarketRepository<MarketDocument>, MarketRepository<MarketDocument>>();
		}
	}
}
