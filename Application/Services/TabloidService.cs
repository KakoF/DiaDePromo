using Domain.Interfaces.Application.Services;
using Domain.Interfaces.Application.UseCases;
using Domain.Interfaces.Infrastructure;
using Domain.Interfaces.Infrastructure.Extrator;
using Domain.Models;
using Domain.Records.Requests.Tabloid;
using Domain.Records.Responses;

namespace Application.Services
{
	public class TabloidService : ITabloideService
	{
		public readonly IStorage _storage;
		public readonly IMarkeUseCase _marketUseCase;
		public readonly IItensExtrator _extrator;
		public TabloidService(IStorage storage, IMarkeUseCase marketUseCase, IItensExtrator extrator)
		{
			_storage = storage;
			_marketUseCase = marketUseCase;
			_extrator = extrator;
		}
		public async Task<TabloidCreateResponse> CreateAsync(TabloidFileRequest request)
		{
			var tabloid = Tabloid.Create(request.MarketName, true);
			var market = Market.Create(request.MarketName);
			var items = await _extrator.ExtractItensInTabloidAsync(request.Tabloide.OpenReadStream());
			
			foreach (var item in items)
				tabloid.Add(item);
			
			market.AddTabloid(tabloid);

			await _marketUseCase.PersistMarketAsync(market);
			
			await _storage.StoragePDFAsync(request.Tabloide.OpenReadStream(), request.Tabloide.FileName);

			return new TabloidCreateResponse(tabloid.Id, market.Name);
		}

		public async Task<TabloidCreateResponse> CreateAsync(TabloidJsonRequest request)
		{
			var tabloid = Tabloid.Create(request.MarketName, false);
			var market = Market.Create(request.MarketName);

			foreach (var item in request.Items)
				tabloid.Add(Item.Create(item.Name, item.Description, item.Type, item.Price, item.ExpirationDate));

			market.AddTabloid(tabloid);

			await _marketUseCase.PersistMarketAsync(market);

			return new TabloidCreateResponse(tabloid.Id, market.Name);
		}
	}
}
