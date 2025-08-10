using Domain.Records.Requests.Items;
using Microsoft.AspNetCore.Http;

namespace Domain.Records.Requests.Tabloid
{
	public record TabloidRequest(string MarketName, long CityId, DateTime ExpirationDate, IFormFile? Tabloide, IEnumerable<ItemsRequest> Items);
}
