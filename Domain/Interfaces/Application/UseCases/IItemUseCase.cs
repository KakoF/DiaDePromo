using Domain.Models;

namespace Domain.Interfaces.Application.UseCases
{
	public interface IItemUseCase
	{
		Task<IEnumerable<Item>> ExtractItemsAsync(Stream file);
	}
}
