using Domain.Interfaces.Application.Services;
using Domain.Interfaces.Application.UseCases;

namespace Application.Services
{
	public class PromoDayService : IPromoDayService
	{
		private readonly IItemUseCase _itemUseCase;
		public PromoDayService(IItemUseCase itemUseCase)
		{
			_itemUseCase = itemUseCase;
		}

		public async Task OrganizePromoDayAsync()
		{
			var itens = await _itemUseCase.GetAsync();
			var cheapestItems = itens.GroupBy(i => i.Name.Split(' ')[0].Trim().ToLower()).Select(g => g.OrderBy(i => i.Price).First()).ToList();
			

			//var itensMaisBaratos = itens.GroupBy(i => i.Name.ToLower()).Select(g => g.OrderBy(i => i.Price).First()).ToList();

			//var itensMaisBaratos = itens.GroupBy(i => i.Name.Trim().ToLower()).Select(g => g.OrderBy(i => i.Price).First()).ToList();



			var test = itens;
		}
	}
}
