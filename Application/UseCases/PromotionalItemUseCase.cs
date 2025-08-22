using Domain.Interfaces.Application.UseCases;
using Domain.Models;
using Infrastructure.Entities.Documents;
using Infrastructure.Interfaces.Repositories;

namespace Application.UseCases
{
	public class PromotionalItemUseCase : IPromotionalItemUseCase
	{
		private readonly IPromotionalItemRepository<PromotionalItemDocument> _itemRepository;
		public PromotionalItemUseCase(IPromotionalItemRepository<PromotionalItemDocument> itemRepository)
		{
			_itemRepository = itemRepository;
		}

		public async Task DeleteItensByDateAsync(DateTime currentDate)
		{
			await _itemRepository.RemoveItensByDateAsync(currentDate);
		}

		public async Task<IEnumerable<PromotionalItem>> GetAsync()
		{
			var collections = await _itemRepository.GetAsync();
			return collections.Select(c => PromotionalItem.Clone(c.Id, c.MarketName, c.CityName, c.Name, c.Description, c.Type, c.Price, c.ExpirationDate));
		}

		public async Task PersistPromotionalItensAsync(string marketName, string cityName, IEnumerable<Item> itens)
		{
			var documents = itens.Select(i => new PromotionalItemDocument(marketName, cityName, i)).ToList();
			await _itemRepository.AddAsync(documents);
		}
	}
}
