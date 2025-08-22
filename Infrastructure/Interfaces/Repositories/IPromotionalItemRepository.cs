
using Infrastructure.Entities.Documents;

namespace Infrastructure.Interfaces.Repositories
{
	public interface IPromotionalItemRepository<Document> where Document : PromotionalItemDocument
	{
		Task<IEnumerable<Document>> GetAsync();
		Task AddAsync(ICollection<Document> documents);
		Task RemoveItensByDateAsync(DateTime currentDate);
	}
}
