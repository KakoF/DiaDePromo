using Domain.Enums;
using Domain.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Entities.Documents
{
	[BsonCollection("Item")]
	[BsonIgnoreExtraElements]
	public class ItemDocument : BaseDocument
	{
		public ItemDocument()
		{
			
		}
		
		public ItemDocument(Item item)
		{
			Id = item.Id;
			Name = item.Name;
			Description = item.Description;
			Type = item.Type;
			Price = item.Price;
			ExpirationDate = item.ExpirationDate;
		}

		[BsonRequired()]
		[BsonElement("name")]
		public string Name { get; set; }

		[BsonRequired()]
		[BsonElement("description")]
		public string? Description { get; set; }

		[BsonRequired()]
		[BsonRepresentation(BsonType.String)]
		[BsonElement("type")]
		public EItemType Type { get; set; }

		[BsonRequired()]
		[BsonElement("price")]
		public decimal Price { get; set; }

		[BsonRequired()]
		[BsonElement("ExpirationDate")]
		public DateTime ExpirationDate { get; set; }


	}
}
