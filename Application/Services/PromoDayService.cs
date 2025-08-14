using Domain.Interfaces.Application.Services;
using Domain.Interfaces.Application.UseCases;
using Domain.Models;
using Domain.Records.Requests.Tabloid;
using Domain.Records.Responses;
using Infrastructure.Interfaces.Storage;

namespace Application.Services
{
	public class PromoDayService : IPromoDayService
	{
		public PromoDayService()
		{
		}

		public Task OrganizePromoDayAsync()
		{
			throw new NotImplementedException();
		}
	}
}
