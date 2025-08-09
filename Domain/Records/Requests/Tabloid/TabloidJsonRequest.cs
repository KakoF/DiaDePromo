using Domain.Records.Requests.Items;
using Microsoft.AspNetCore.Http;

namespace Domain.Records.Requests.Tabloid
{
	public record TabloidJsonRequest(string MarketName, IEnumerable<ItemsJsonRequest> Items);
}
