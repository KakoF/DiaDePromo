using Domain.Interfaces.Infrastructure;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Storage
{
	public class Storage : IStorage
	{
		public void StoragePDFAsync(IFormFile file)
		{
			throw new NotImplementedException();
		}
	}
}
