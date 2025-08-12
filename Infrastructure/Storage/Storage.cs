using Infrastructure.Interfaces.Storage;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Storage
{
	public class Storage : IStorage
	{
		private string FOLDER = "Tabloids";
		public Storage()
		{
			Directory.CreateDirectory(FOLDER);
		}

		public async Task StoragePDFAsync(Stream? file, string name)
		{
			if (file == null)
				return;

			string caminhoCompleto = Path.Combine(FOLDER, name);

			using (var fileStream = new FileStream(caminhoCompleto, FileMode.Create))
			{
				await file.CopyToAsync(fileStream);
			}
		}

		public void StoragePDFAsync(IFormFile file)
		{
			throw new NotImplementedException();
		}
	}
}
