using Domain.Interfaces.Application.UseCases;
using Domain.Models;
using Infrastructure.Interfaces.Repositories;
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
			var entity = await _cityRepository.GetAsync();
			return entity.Where(x => x.Active == true).Select(x => new City() { Id = x.Id, Name = x.Name, Active = x.Active});
		}

		public async Task<City> GetAsync(long id)
		{
			var entity = await _cityRepository.GetAsync(id);
			return new City() { Id = entity.Id, Name = entity.Name, Active = entity.Active };
		}
	}
}
