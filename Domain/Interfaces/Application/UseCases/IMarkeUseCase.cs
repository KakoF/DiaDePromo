using Domain.Models;

namespace Domain.Interfaces.Application.UseCases
{
	public interface IMarkeUseCase
	{
		public Task PersistMarketAsync(Market market);
	}
}
