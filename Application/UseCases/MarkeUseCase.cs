using Domain.Interfaces.Application.UseCases;
using Domain.Models;
using Infrastructure.Entities.Documents;
using Infrastructure.Interfaces.Repositories;

namespace Application.UseCases
{
	public class MarkeUseCase : IMarkeUseCase
	{
		private readonly IMarketRepository<MarketDocument> _marketRepository;
		public MarkeUseCase(IMarketRepository<MarketDocument> marketRepository)
		{
			_marketRepository = marketRepository;
		}
		public async Task<Market> PersistMarketAsync(Market market)
		{
			var entity = await _marketRepository.GetAsync(market.Name, market.Tabloids.FirstOrDefault().CityName);
			if(entity == null)
			{
				await _marketRepository.SaveAsync(new MarketDocument(market));
				return market;
			}
			await _marketRepository.AddTabloidAsync(market.Name, market.Tabloids.FirstOrDefault().CityName, new TabloidDocument(market.Tabloids.FirstOrDefault()));
			return market;

		}
	}
}
