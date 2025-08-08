using Domain.Interfaces.Services;
using Domain.Records.Requests;
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
		public async Task<IActionResult> Save([FromForm] TabloideRequest form)
		{
			await _service.ConvertPDFAsync(form);
			return Ok();
		}
	}
}
