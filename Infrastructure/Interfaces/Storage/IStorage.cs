using Microsoft.AspNetCore.Http;

namespace Infrastructure.Interfaces.Storage
{
	public interface IStorage
	{
		Task StoragePDFAsync(IEnumerable<IFormFile>? files, Guid id, string name);
	}
}
