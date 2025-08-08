using Domain.Interfaces.Infrastructure;
using Domain.Interfaces.Services;
using Domain.Records.Requests;

namespace Application.Services
{
	public class TabloidService : ITabloideService
	{
		public readonly IStorage _storage;
		public TabloidService(IStorage storage)
		{
			_storage = storage;
		}
		public async Task ConvertPDFAsync(TabloideRequest request)
		{
			await _storage.StoragePDFAsync(request.Tabloide.OpenReadStream(), request.Tabloide.FileName);
		}
	}
}
