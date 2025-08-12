using Infrastructure.Entities;

namespace Infrastructure.Interfaces.Repositories
{
	public interface ICityRepository
	{
		Task<IEnumerable<CityEntity>> GetAsync();
		Task<CityEntity> GetAsync(long id);
	}
}
