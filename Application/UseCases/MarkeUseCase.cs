using Domain.Interfaces.Application.UseCases;
using Domain.Models;

namespace Application.UseCases
{
	public class MarkeUseCase : IMarkeUseCase
	{
		public Task PersistMarketAsync(Market market)
		{
			return Task.FromResult("OK");
		}
	}
}
