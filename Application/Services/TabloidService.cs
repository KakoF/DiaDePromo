using Domain.Interfaces.Infrastructure;
using Domain.Interfaces.Services;
using Domain.Models;
using Domain.Records.Requests;
using Domain.Records.Responses;

namespace Application.Services
{
	public class TabloidService : ITabloideService
	{
		public readonly IStorage _storage;
		public TabloidService(IStorage storage)
		{
			_storage = storage;
		}
		public async Task<TabloidCreateResponse> CreateAsync(TabloideRequest request)
		{
			var tabloid = Tabloid.Create(
				request.MarketName, 
				Market.Create(request.MarketName));

			await _storage.StoragePDFAsync(request.Tabloide.OpenReadStream(), request.Tabloide.FileName);

			return new TabloidCreateResponse(tabloid.Id, tabloid.Market.Name);
		}
	}
}
