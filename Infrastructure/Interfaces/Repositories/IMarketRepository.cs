
using Infrastructure.Entities.Documents;

namespace Infrastructure.Interfaces.Repositories
{
	public interface IMarketRepository<Document> where Document : MarketDocument
	{
		Task<Document> GetAsync(string marketName, string cityName);
		Task AddOrUpdateMarketAsync(Document document);
	}
}
