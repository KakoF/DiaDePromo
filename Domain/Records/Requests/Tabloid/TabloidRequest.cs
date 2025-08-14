using Domain.Records.Requests.Items;
using Microsoft.AspNetCore.Http;

namespace Domain.Records.Requests.Tabloid
{
	public record TabloidRequest(string MarketName, string TabloidName, long CityId, DateTime ExpirationDate, IEnumerable<IFormFile>? Tabloids, IEnumerable<ItemsRequest> Items);
}
