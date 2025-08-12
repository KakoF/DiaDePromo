
using Infrastructure.Entities.Documents;

namespace Infrastructure.Interfaces.Repositories
{
	public interface IMarketRepository<Document> where Document : MarketDocument
	{
		Task SaveAsync(Document document);
	}
}
