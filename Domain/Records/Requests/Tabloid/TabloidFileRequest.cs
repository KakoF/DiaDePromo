using Microsoft.AspNetCore.Http;

namespace Domain.Records.Requests.Tabloid
{
	public record TabloidFileRequest(string MarketName, IFormFile Tabloide);
}
