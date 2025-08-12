
using Domain.Models;

namespace Domain.Interfaces.Application.UseCases
{
	public interface ICityUseCase
	{
		Task<IEnumerable<City>> GetAsync();
		Task<City> GetAsync(long id);
	}
}
