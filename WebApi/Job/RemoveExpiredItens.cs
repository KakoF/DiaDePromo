using Domain.Interfaces.Application.UseCases;

namespace WebApi.Job
{
	public class RemoveExpiredItens
	{
		private readonly IItemUseCase _itemUseCase;
		public RemoveExpiredItens(IItemUseCase itemUseCase)
		{
			_itemUseCase = itemUseCase;
		}
		public async Task ExecuteAsync()
		{
			await _itemUseCase.DeleteItensByDateAsync(DateTime.Now);
		}
	}
}
