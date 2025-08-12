
using Domain.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Entities.Documents
{
	[BsonCollection("Tabloid")]
	[BsonIgnoreExtraElements]
	public class TabloidDocument: BaseDocument
	{
		public TabloidDocument()
		{
			
		}
		
		public TabloidDocument(Tabloid tabloid)
		{
			Id = tabloid.Id;
			Name = tabloid.Name;
		}

		[BsonRequired()]
		[BsonElement("name")]
		public string Name { get; set; }

		
	}
}
