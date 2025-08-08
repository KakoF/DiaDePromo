using Domain.Enums;

namespace Domain.Models
{
	public sealed class Item
	{
		public string Name { get; private set; } = null!;
		public string? Description { get; private set; }
		public EItemType Type { get; private set; }
		public decimal Price { get; private set; }
		public DateTime? ExpirationDate { get; private set; }


		private Item(string name, string? description, EItemType type, decimal price, DateTime? expirationDate)
		{
			Name = name;
			Description = description;
			Type = type;
			Price = price;
			ExpirationDate = expirationDate;
		}

		public static Item Create(string name, string? description, EItemType type, decimal price, DateTime? expirationDate)
		{
			return new Item(name, description, type, price, expirationDate);
		}
	}
}
