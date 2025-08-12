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
			
			await _marketRepository.AddOrUpdateMarketAsync(new MarketDocument(market));
			return market;

		}
	}
}
