using Microsoft.AspNetCore.Http;

namespace Domain.Records.Requests
{
	public record TabloideRequest(string MarketName, IFormFile Tabloide);
}
