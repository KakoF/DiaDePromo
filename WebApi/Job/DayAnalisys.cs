using Domain.Interfaces.Application.Services;

namespace WebApi.Job
{
	public class DayAnalisys
	{
		private readonly IPromoDayService _promoDayService;
		public DayAnalisys(IPromoDayService promoDayService)
		{
			_promoDayService = promoDayService;
		}
		public async Task ExecuteAsync()
		{
			await _promoDayService.OrganizePromoDayAsync();
		}
	}
}
