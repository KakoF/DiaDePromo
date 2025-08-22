using Domain.Interfaces.Application.UseCases;

namespace WebApi.Job
{
	public class RemoveExpiredItens
	{
		private readonly IPromotionalItemUseCase _itemUseCase;
		public RemoveExpiredItens(IPromotionalItemUseCase itemUseCase)
		{
			_itemUseCase = itemUseCase;
		}
		public async Task ExecuteAsync()
		{
			await _itemUseCase.DeleteItensByDateAsync(DateTime.Now);
		}
	}
}
