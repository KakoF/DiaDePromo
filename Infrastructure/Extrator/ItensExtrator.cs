using Domain.Interfaces.Infrastructure.Extrator;
using Domain.Models;

namespace Infrastructure.Extrator
{
	public class ItensExtrator : IItensExtrator
	{
		public async Task<List<Item>> ExtractItensInTabloidAsync(Stream file)
		{
			var itens = new List<Item>();
			return await Task.FromResult(itens);
		}

	}
}
