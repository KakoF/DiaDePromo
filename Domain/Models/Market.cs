using Domain.Enums;
using Domain.Exceptions;

namespace Domain.Models
{
	public sealed class Market
	{
		public Guid Id { get; private set; }
		public string Name { get; private set; } = null!;
		private List<Tabloid> _tabloids = new();
		public IReadOnlyCollection<Tabloid> Tabloids => _tabloids.AsReadOnly();

		private Market(Guid id, string name)
		{
			Id = id;
			Name = name;
		}

		public static Market Create(string name)
		{
			if (string.IsNullOrEmpty(name))
				throw new DomainException("Market name must have value");

			return new Market(Guid.NewGuid(), name);
		}

		public void AddTabloid(Tabloid tabloid)
		{
			_tabloids.Add(tabloid);
		}
	}
}
