using Infrastructure.Context;
using Infrastructure.Entities.Documents;
using Infrastructure.Interfaces.Repositories;

namespace Infrastructure.Repositories
{
	public class ItemRepository<Document> : IItemRepository<Document> where Document : ItemDocument
	{
		private readonly IMongoRepository<Document> _repository;
		public ItemRepository(IMongoRepository<Document> repository)
		{
			_repository = repository;
		}
		public async Task AddAsync(ICollection<Document> documents)
		{
			await _repository.InsertManyAsync(documents);
		}

		public async Task RemoveItensByDateAsync(DateTime currentDate)
		{
			await _repository.DeleteManyAsync((x => x.ExpirationDate < currentDate));
		}
	}
}
