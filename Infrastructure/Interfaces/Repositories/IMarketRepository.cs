
using Infrastructure.Entities.Documents;

namespace Infrastructure.Interfaces.Repositories
{
	public interface IMarketRepository<Document> where Document : MarketDocument
	{
		Task SaveAsync(Document document);
		Task<Document> GetAsync(string marketName, string cityName);
		Task AddTabloidAsync(string marketName, string cityName, TabloidDocument tabloid);
	}
}
