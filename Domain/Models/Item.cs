using Domain.Enums;
using Domain.Exceptions;

namespace Domain.Models
{
	public sealed class Item
	{
		public Guid Id { get; private set; }
		public string Name { get; private set; } = null!;
		public string? Description { get; private set; }
		public EItemType Type { get; private set; }
		public decimal Price { get; private set; }
		public DateTime ExpirationDate { get; private set; }


		private Item(Guid id, string name, string? description, EItemType type, decimal price, DateTime expirationDate)
		{
			Id = id;
			Name = name;
			Description = description;
			Type = type;
			Price = price;
			ExpirationDate = expirationDate;
		}

		public static Item Clone(Guid id, string name, string? description, EItemType type, decimal price, DateTime expirationDate)
		{
			return new Item(id, name, description, type, price, expirationDate);
		}

		public static Item Create(string name, string? description, EItemType type, decimal price, DateTime expirationDate)
		{
			if (string.IsNullOrEmpty(name))
				throw new DomainException("Item name must have value");

			if (!Enum.IsDefined(typeof(EItemType), type))
				throw new DomainException("Item type is not valid.");

			if (expirationDate.Date < DateTime.Now.Date)
				throw new DomainException("Item expiration date must have biggest then current date");

			return new Item(Guid.NewGuid(), name, description, type, price, expirationDate);
		}
	}
}
