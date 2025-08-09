using Domain.Enums;
using Domain.Exceptions;
using System.Formats.Tar;

namespace Domain.Models
{
	public sealed class Tabloid
	{
		public Guid Id { get; private set; }
		public bool HasFile { get; private set; }
		public string Name { get; private set; } = null!;
		private List<Item> _items = new();
		public IReadOnlyCollection<Item> Items => _items.AsReadOnly();

		private Tabloid(Guid id, string name, bool hasFile)
		{
			Id = id;
			Name = name;
			HasFile = hasFile;
		}

		public static Tabloid Create(string name, bool hasFile)
		{
			if (string.IsNullOrEmpty(name))
				throw new DomainException("Tabloid name must have value");

			var id = Guid.NewGuid();
			name = $"{id}_{name}";
			
			return new Tabloid(id, name, hasFile);
		}

		public void Add(Item item)
		{
			_items.Add(item);
		}

	}
}
