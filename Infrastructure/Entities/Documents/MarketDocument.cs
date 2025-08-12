
using Domain.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Entities.Documents
{
	[BsonCollection("Market")]
	[BsonIgnoreExtraElements]
	public class MarketDocument : BaseDocument
	{
		public MarketDocument()
		{
		}
		public MarketDocument(Market market)
		{
			Id = market.Id;
			Name = market.Name;
			City.Add(new CityDocument(market.Tabloids!.FirstOrDefault()!));
		}

		[BsonRequired()]
		[BsonElement("name")]
		public string Name { get; set; }

		[BsonRequired()]
		[BsonElement("city")]
		public List<CityDocument> City { get; set; } = new List<CityDocument>();

	}
}
