using Domain.Entities;


namespace Domain.Interfaces.Infrastructure.Repositories
{
	public interface ICityRepository
	{
		Task<IEnumerable<City>> GetAsync();
		Task<City> GetAsync(long id);
	}
}
