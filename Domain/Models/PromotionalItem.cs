using Domain.Enums;

namespace Domain.Models
{
	public sealed class PromotionalItem
	{
		public Guid Id { get; private set; }
		public string MarketName { get; private set; } = null!;
		public string CityName { get; private set; } = null!;
		public string Name { get; private set; } = null!;
		public string? Description { get; private set; }
		public EItemType Type { get; private set; }
		public decimal Price { get; private set; }
		public DateTime ExpirationDate { get; private set; }


		private PromotionalItem(Guid id, string marketName, string cityName, string name, string? description, EItemType type, decimal price, DateTime expirationDate)
		{
			Id = id;
			MarketName = marketName;
			CityName = cityName;
			Name = name;
			Description = description;
			Type = type;
			Price = price;
			ExpirationDate = expirationDate;
		}

		public static PromotionalItem Clone(Guid id, string marketName, string cityName, string name, string? description, EItemType type, decimal price, DateTime expirationDate)
		{
			return new PromotionalItem(id, marketName, cityName, name, description, type, price, expirationDate);
		}
	}
}
