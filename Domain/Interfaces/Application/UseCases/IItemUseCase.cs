using Domain.Models;

namespace Domain.Interfaces.Application.UseCases
{
	public interface IItemUseCase
	{
		Task<IEnumerable<Item>> GetAsync();
		Task PersistItensAsync(IEnumerable<Item> itens);
		Task DeleteItensByDateAsync(DateTime currentDate);
	}
}
