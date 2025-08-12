
using Domain.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Entities.Documents
{
	public class TabloidDocument
	{
		public TabloidDocument(Market market)
		{
			Name = market.Name;
		}

		[BsonRequired()]
		[BsonElement("name")]
		public string Name { get; }
		
	}
}
