
using Domain.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Entities.Documents
{
	[BsonCollection("City")]
	[BsonIgnoreExtraElements]
	public class CityDocument
	{
		public CityDocument()
		{
			
		}
		
		public CityDocument(Tabloid tabloid)
		{
			Name = tabloid!.CityName;
			Tabloid.Add(new TabloidDocument(tabloid!));
		}

		[BsonRequired()]
		[BsonElement("name")]
		public string Name { get; set; }

		[BsonRequired()]
		[BsonElement("tabloid")]
		public List<TabloidDocument> Tabloid { get; set; } = new List<TabloidDocument>();
	}
}
