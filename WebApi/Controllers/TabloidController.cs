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

		[HttpPost("File")]
		public async Task<TabloidCreateResponse> SaveFileAsync([FromForm] TabloidFileRequest form)
		{
			return await _service.CreateAsync(form);
		}

		[HttpPost("Body")]
		public async Task<TabloidCreateResponse> SaveAsync([FromBody] TabloidJsonRequest body)
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
