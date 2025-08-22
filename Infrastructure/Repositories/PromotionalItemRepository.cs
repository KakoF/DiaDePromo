using Infrastructure.Context;
using Infrastructure.Entities.Documents;
using Infrastructure.Interfaces.Repositories;

namespace Infrastructure.Repositories
{
	public class PromotionalItemRepository<Document> : IPromotionalItemRepository<Document> where Document : PromotionalItemDocument
	{
		private readonly IMongoRepository<Document> _repository;
		public PromotionalItemRepository(IMongoRepository<Document> repository)
		{
			_repository = repository;
		}
		public async Task AddAsync(ICollection<Document> documents)
		{
			await _repository.InsertManyAsync(documents);
		}

		public async Task<IEnumerable<Document>> GetAsync()
		{
			return await _repository.FindAllAsync();
		}

		public async Task RemoveItensByDateAsync(DateTime currentDate)
		{
			await _repository.DeleteManyAsync((x => x.ExpirationDate < currentDate));
		}
	}
}
