using Infrastructure.Context;
using Infrastructure.Entities.Documents;
using Infrastructure.Interfaces.Repositories;
using System.Reflection.Metadata;

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
	}
}
