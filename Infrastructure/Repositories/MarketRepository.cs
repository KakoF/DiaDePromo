using Infrastructure.Context;
using Infrastructure.Entities.Documents;
using Infrastructure.Interfaces.Repositories;
using MongoDB.Driver;
using System.Linq.Expressions;


namespace Infrastructure.Repositories
{
	public class MarketRepository<Document> : IMarketRepository<Document> where Document : MarketDocument
	{
		private readonly IMongoRepository<Document> _repository;
		public MarketRepository(IMongoRepository<Document> repository)
		{
			_repository = repository;
		}

		public async Task<Document> GetAsync(string marketName, string cityName)
		{
			return await _repository.FindOneAsync((x => x.Name == marketName && x.City.FirstOrDefault().Name == cityName));
		}

		public async Task AddOrUpdateMarketAsync(Document document)
		{
			Expression<Func<Document, bool>> filterExpression = d =>
				d.Name == document.Name;
				//&& d.City.Any(c => c.Name == document.City.FirstOrDefault()!.Name);

			var entity = await _repository.FilterByAsync(filterExpression);

			if (entity.Any())
			{
				if (entity!.FirstOrDefault()!.City.Any(c => c.Name == document.City.FirstOrDefault()!.Name))
				{
					await AddMarketTabloidInCityAsync(document);
					return;
				}
				await AddMarketTabloidAsync(document);
				return;
			}

			await _repository.InsertOneAsync(document);
		}

		private async Task AddMarketTabloidInCityAsync(Document document)
		{
			var filter = Builders<Document>.Filter.And(
				Builders<Document>.Filter.Eq(d => d.Name, document.Name),
				Builders<Document>.Filter.ElemMatch(d => d.City,
					Builders<CityDocument>.Filter.And(
						Builders<CityDocument>.Filter.Eq(c => c.Name, document.City.FirstOrDefault()!.Name)
						)
					)
				);

			var update = Builders<Document>.Update.PushEach("city.$.tabloid", document.City.FirstOrDefault()!.Tabloid);
			await _repository.UpdateOneAsync(filter, update);
		}

		private async Task AddMarketTabloidAsync(Document document)
		{
			var filter = Builders<Document>.Filter.And(
				Builders<Document>.Filter.Eq(d => d.Name, document.Name));
			var update = Builders<Document>.Update.Push("city", document.City.FirstOrDefault());
			await _repository.UpdateOneAsync(filter, update);
		}
	}
}
