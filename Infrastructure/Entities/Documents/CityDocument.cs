
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
		public CityDocument(string cityName, IReadOnlyCollection<Tabloid> tabloids)
		{

			Name = cityName;
			foreach (var tabloid in tabloids)
			{
				Tabloid.Add(new TabloidDocument(tabloid, tabloid.Items.ToList()));
			}
		}
		
		[BsonRequired()]
		[BsonElement("name")]
		public string Name { get; set; }

		[BsonRequired()]
		[BsonElement("tabloid")]
		public List<TabloidDocument> Tabloid { get; set; } = new List<TabloidDocument>();
	}
}
