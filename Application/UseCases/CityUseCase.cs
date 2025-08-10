using Domain.Entities;
using Domain.Interfaces.Application.UseCases;
using Domain.Interfaces.Infrastructure.Repositories;
namespace Application.UseCases
{
	public class CityUseCase : ICityUseCase
	{
		private readonly ICityRepository _cityRepository;
		public CityUseCase(ICityRepository cityRepository)
		{
			_cityRepository = cityRepository;
		}
		public async Task<IEnumerable<City>> GetAsync()
		{
			var cities = await _cityRepository.GetAsync();
			return cities.Where(x => x.Active == true);
		}

		public async Task<City> GetAsync(long id)
		{
			return await _cityRepository.GetAsync(id);
		}
	}
}
