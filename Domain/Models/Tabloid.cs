namespace Domain.Models
{
	public sealed class Tabloid
	{
		public Guid Id { get; private set; }
		public string Name { get; private set; } = null!;
		private List<Item> _items = new();
		private Market _market;
		public IReadOnlyCollection<Item> Items => _items.AsReadOnly();
		public Market Market => _market;

		private Tabloid(Guid id, string name, Market market)
		{
			Id = id;
			Name = name;
			_market = market;
		}

		public static Tabloid Create(string name, Market market)
		{
			var id = Guid.NewGuid();
			name = $"{id}_{name}";
			return new Tabloid(id, name, market);
		}

		public void Add(Item item)
		{
			_items.Add(item);
		}

	}
}
