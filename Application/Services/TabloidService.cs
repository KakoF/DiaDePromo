using Domain.Interfaces.Application.Services;
using Domain.Interfaces.Application.UseCases;
using Domain.Models;
using Domain.Records.Requests.Tabloid;
using Domain.Records.Responses;
using Infrastructure.Interfaces.Storage;

namespace Application.Services
{
	public class TabloidService : ITabloideService
	{
		public readonly IStorage _storage;
		public readonly IMarkeUseCase _marketUseCase;
		public readonly IPromotionalItemUseCase _itemUseCase;
		public readonly ICityUseCase _cityUseCase;
		public TabloidService(IStorage storage, IMarkeUseCase marketUseCase, ICityUseCase cityUseCase, IPromotionalItemUseCase itemUseCase	)
		{
			_storage = storage;
			_marketUseCase = marketUseCase;
			_cityUseCase = cityUseCase;
			_itemUseCase = itemUseCase;
		}

		public async Task<TabloidCreateResponse> CreateAsync(TabloidRequest request)
		{
			var city = await _cityUseCase.GetAsync(request.CityId);
			var tabloid = Tabloid.Create(request.TabloidName, (request.Tabloids?.Any() ?? false), (request.Tabloids?.Count() ?? 0), city.Name, request.ExpirationDate);
			var market = Market.Create(request.MarketName);

			foreach (var item in request.Items)
				tabloid.Add(Item.Create(item.Name, item.Description, item.Type, item.Price, item.ExpirationDate ?? request.ExpirationDate));

			market.AddTabloid(tabloid);

			tabloid.ValidateItems();

			await _storage.StoragePDFAsync(request.Tabloids, tabloid.Id, tabloid.Name);

			await _marketUseCase.PersistMarketAsync(market);
			await _itemUseCase.PersistPromotionalItensAsync(market.Name, market.Tabloids.FirstOrDefault()!.CityName, market.Tabloids.FirstOrDefault()!.Items);

			return new TabloidCreateResponse(tabloid.Id, market.Name);
		}
	}
}
