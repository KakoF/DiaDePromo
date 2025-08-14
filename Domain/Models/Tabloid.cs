using Domain.Exceptions;

namespace Domain.Models
{
	public sealed class Tabloid
	{
		public Guid Id { get; private set; }
		public bool HasFile { get; private set; }
		public int NumberFilePages { get; private set; }
		public string CityName { get; private set; }
		public string Name { get; private set; } = null!;
		public DateTime ExpirationDate { get; private set; }
		
		private List<Item> _items = new();
		public IReadOnlyCollection<Item> Items => _items.AsReadOnly();

		private Tabloid(Guid id, string name, bool hasFile, int numberFilePages, string cityName, DateTime expirationDate)
		{
			Id = id;
			Name = name;
			HasFile = hasFile;
			NumberFilePages = numberFilePages;
			CityName = cityName;
			ExpirationDate = expirationDate;
		}

		public static Tabloid Create(string name, bool hasFile, int numberFilePages, string cityName, DateTime expirationDate)
		{
			if (string.IsNullOrEmpty(name))
				throw new DomainException("Tabloid name must have value");

			if (string.IsNullOrEmpty(cityName))
				throw new DomainException("Tabloid city name must have value");

			if (expirationDate.Date < DateTime.Now.Date)
				throw new DomainException("Tabloid expiration date must have biggest then current date");

			var id = Guid.NewGuid();
			
			return new Tabloid(id, name, hasFile, numberFilePages, cityName, expirationDate);
		}

		public void Add(Item item)
		{
			_items.Add(item);
		}

		public void ValidateItems()
		{
			if (!_items.Any())
				throw new DomainException("Tabloid has no items");
		}
	}
}
