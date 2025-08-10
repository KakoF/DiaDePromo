using Domain.Interfaces.Application.Services;
using Domain.Records.Requests.Tabloid;
using Domain.Records.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TabloidController : ControllerBase
	{
		private readonly ITabloideService _service;
		public TabloidController(ITabloideService service)
		{
			_service = service;
		}


		[HttpPost]
		[Consumes("multipart/form-data")]
		public async Task<TabloidCreateResponse> SaveAsync([FromForm] TabloidRequest body)
		{
			return await _service.CreateAsync(body);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetAsync(Guid id)
		{
			return Ok();
		}
	}
}
