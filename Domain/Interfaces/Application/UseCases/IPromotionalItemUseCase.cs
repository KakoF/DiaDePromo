using Domain.Models;

namespace Domain.Interfaces.Application.UseCases
{
	public interface IPromotionalItemUseCase
	{
		Task<IEnumerable<PromotionalItem>> GetAsync();
		Task PersistPromotionalItensAsync(string marketName, string cityName, IEnumerable<Item> itens);
		Task DeleteItensByDateAsync(DateTime currentDate);
	}
}
