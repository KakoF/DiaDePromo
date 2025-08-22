
using Infrastructure.Entities.Documents;

namespace Infrastructure.Interfaces.Repositories
{
	public interface IItemRepository<Document> where Document : ItemDocument
	{
		Task AddAsync(ICollection<Document> documents);
		Task RemoveItensByDateAsync(DateTime currentDate);
	}
}
