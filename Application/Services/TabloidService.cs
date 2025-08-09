using Domain.Interfaces.Application.Services;
using Domain.Interfaces.Application.UseCases;
using Domain.Interfaces.Infrastructure;
using Domain.Models;
using Domain.Records.Requests;
using Domain.Records.Responses;

namespace Application.Services
{
	public class TabloidService : ITabloideService
	{
		public readonly IStorage _storage;
		public readonly IMarkeUseCase _marketUseCase;
		public readonly IItemUseCase _itemUseCase;
		public TabloidService(IStorage storage, IMarkeUseCase marketUseCase, IItemUseCase itemUseCase)
		{
			_storage = storage;
			_marketUseCase = marketUseCase;
			_itemUseCase = itemUseCase;
		}
		public async Task<TabloidCreateResponse> CreateAsync(TabloideRequest request)
		{
			var tabloid = Tabloid.Create(request.MarketName);
			var market = Market.Create(request.MarketName);
			var items = await _itemUseCase.ExtractItemsAsync(request.Tabloide.OpenReadStream());
			
			foreach (var item in items)
				tabloid.Add(item);
			
			market.AddTabloid(tabloid);

			await _marketUseCase.PersistMarketAsync(market);
			
			await _storage.StoragePDFAsync(request.Tabloide.OpenReadStream(), request.Tabloide.FileName);

			return new TabloidCreateResponse(tabloid.Id, market.Name);
		}
	}
}
