using Domain.Interfaces.Application.Services;
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
		public async Task<IActionResult> SaveAsync([FromForm] TabloideRequest form)
		{
			await _service.CreateAsync(form);
			return Ok();
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetAsync(Guid id)
		{
			return Ok();
		}
	}
}
