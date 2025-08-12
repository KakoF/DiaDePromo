using Domain.Models;

namespace Domain.Interfaces.Application.UseCases
{
	public interface IMarkeUseCase
	{
		Task<Market> PersistMarketAsync(Market market);
	}
}
