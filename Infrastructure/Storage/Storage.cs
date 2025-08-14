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

		private async Task StoragePDFAsync(Stream? file, string name)
		{
			if (file == null)
				return;

			string caminhoCompleto = Path.Combine(FOLDER, name);

			using (var fileStream = new FileStream(caminhoCompleto, FileMode.Create))
			{
				await file.CopyToAsync(fileStream);
			}
		}

		public async Task StoragePDFAsync(IEnumerable<IFormFile>? files, Guid id, string name)
		{
			if (files != null && files.Any())
			{
				foreach (var item in files.Select((file, index) => new { file, index }))
				{
					var newName = $"{id}_{name}_{item.index}.pdf";
					await StoragePDFAsync(item.file.OpenReadStream(), newName);
				}
			}
		}
	}
}
