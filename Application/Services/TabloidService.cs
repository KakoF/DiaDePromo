using Domain.Interfaces.Application.Services;
using Domain.Interfaces.Application.UseCases;
using Domain.Interfaces.Infrastructure;
using Domain.Models;
using Domain.Records.Requests.Tabloid;
using Domain.Records.Responses;

namespace Application.Services
{
	public class TabloidService : ITabloideService
	{
		public readonly IStorage _storage;
		public readonly IMarkeUseCase _marketUseCase;
		public readonly ICityUseCase _cityUseCase;
		public TabloidService(IStorage storage, IMarkeUseCase marketUseCase, ICityUseCase cityUseCase)
		{
			_storage = storage;
			_marketUseCase = marketUseCase;
			_cityUseCase = cityUseCase;
		}

		public async Task<TabloidCreateResponse> CreateAsync(TabloidRequest request)
		{
			var city = await _cityUseCase.GetAsync(request.CityId);
			var tabloid = Tabloid.Create(request.MarketName, (request.Tabloide != null ? true : false), city.Name, request.ExpirationDate);
			var market = Market.Create(request.MarketName);

			foreach (var item in request.Items)
				tabloid.Add(Item.Create(item.Name, item.Description, item.Type, item.Price, item.ExpirationDate ?? request.ExpirationDate));

			market.AddTabloid(tabloid);

			tabloid.hasItems();

			await _storage.StoragePDFAsync(request?.Tabloide?.OpenReadStream(), tabloid.Name);

			await _marketUseCase.PersistMarketAsync(market);

			return new TabloidCreateResponse(tabloid.Id, market.Name);
		}
	}
}
