using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
	public sealed class Market
	{
		public Guid Id { get; private set; }
		public string Name { get; private set; } = null!;
		private List<Tabloid> _tabloids = new();
		public IReadOnlyCollection<Tabloid> Tabloids => _tabloids.AsReadOnly();

	}
}
