
using Infrastructure.Entities.Documents;

namespace Infrastructure.Interfaces.Repositories
{
	public interface IMarketRepository<Document> where Document : MarketDocument
	{
		Task<Document> GetAsync(string marketName, string cityName);
		Task AddTabloidAsync(string marketName, string cityName, TabloidDocument tabloid);
		Task AddOrUpdateMarketAsync(Document document);
	}
}
