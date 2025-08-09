
using Domain.Models;

namespace Domain.Interfaces.Infrastructure.Extrator
{
	public interface IItensExtrator
	{
		Task<List<Item>> ExtractItensInTabloidAsync(Stream file);
	}
}
