using Domain.Interfaces.Application.UseCases;
using Domain.Models;
using Infrastructure.Entities.Documents;
using Infrastructure.Interfaces.Repositories;

namespace Application.UseCases
{
	public class ItemUseCase : IItemUseCase
	{
		private readonly IItemRepository<ItemDocument> _itemRepository;
		public ItemUseCase(IItemRepository<ItemDocument> itemRepository)
		{
			_itemRepository = itemRepository;
		}

		public async Task DeleteItensByDateAsync(DateTime currentDate)
		{
			await _itemRepository.RemoveItensByDateAsync(currentDate);
		}

		public async Task PersistItensAsync(IEnumerable<Item> itens)
		{
			var documents = itens.Select(i => new ItemDocument(i)).ToList();
			await _itemRepository.AddAsync(documents);
		}
	}
}
