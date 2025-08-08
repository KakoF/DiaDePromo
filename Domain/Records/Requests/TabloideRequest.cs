using Microsoft.AspNetCore.Http;

namespace Domain.Records.Requests
{
	public class TabloideRequest
	{
		public IFormFile Tabloide { get; set; } = null!;
    }
}
