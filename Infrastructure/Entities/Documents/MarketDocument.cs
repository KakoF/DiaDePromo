
using Domain.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Entities.Documents
{
	[BsonCollection("Market")]
	[BsonIgnoreExtraElements]
	public class MarketDocument : BaseDocument
	{
		public MarketDocument(Market market)
		{
			Name = market.Name;
		}

		[BsonRequired()]
		[BsonElement("name")]
		public string Name { get; }
		
	}
}
