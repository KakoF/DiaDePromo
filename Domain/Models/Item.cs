using Domain.Enums;
using Domain.Exceptions;
using System.Drawing;

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
			if (string.IsNullOrEmpty(name))
				throw new DomainException("Item name must have value");

			if (!Enum.IsDefined(typeof(EItemType), type))
				throw new DomainException("Type is not valid.");

			return new Item(name, description, type, price, expirationDate);
		}
	}
}
