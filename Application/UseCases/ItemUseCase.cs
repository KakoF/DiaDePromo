using Domain.Interfaces.Application.UseCases;
using Domain.Models;

namespace Application.UseCases
{
	public class ItemUseCase : IItemUseCase
	{
		public Task<IEnumerable<Item>> ExtractItemsAsync(Stream file)
		{
			throw new NotImplementedException();
		}
	}
}
