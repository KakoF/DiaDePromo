using Infrastructure.Context;
using Infrastructure.Entities.Documents;
using Infrastructure.Interfaces.Repositories;
using MongoDB.Driver;


namespace Infrastructure.Repositories
{
	public class MarketRepository<Document> : IMarketRepository<Document> where Document : MarketDocument
	{
		private readonly IMongoRepository<Document> _repository;
		public MarketRepository(IMongoRepository<Document> repository)
		{
			_repository = repository;
		}

		public async Task SaveAsync(Document document)
		{
			await _repository.InsertOneAsync(document);
		}

		public async Task<Document> GetAsync(string marketName, string cityName)
		{
			return await _repository.FindOneAsync((x => x.Name == marketName && x.City.FirstOrDefault().Name == cityName));
		}

		public async Task AddTabloidAsync(string marketName, string cityName, TabloidDocument tabloid)
		{
			var filter = Builders<Document>.Filter.And(
				Builders<Document>.Filter.Eq(d => d.Name, marketName),
				Builders<Document>.Filter.ElemMatch(d => d.City,
					Builders<CityDocument>.Filter.And(
						Builders<CityDocument>.Filter.Eq(c => c.Name, cityName)
					)
				)
			);

			var update = Builders<Document>.Update.Push("city.$.tabloid", tabloid);

			await _repository.UpdateOneAsync(filter, update);

		}
	}
}
