
using Domain.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Entities.Documents
{
	[BsonCollection("Tabloid")]
	[BsonIgnoreExtraElements]
	public class TabloidDocument: BaseDocument
	{
		
		public TabloidDocument(Tabloid tabloid, IReadOnlyCollection<Item> items)
		{
			Id = tabloid.Id;
			Name = tabloid.Name;
			foreach (var item in items)
			{
				Item.Add(new ItemDocument(item));
			}
			HasFile = tabloid.HasFile;
			NumberFilePages = tabloid.NumberFilePages;
			ExpirationDate = tabloid.ExpirationDate;
		}

		[BsonRequired()]
		[BsonElement("name")]
		public string Name { get; set; }
		[BsonRequired()]
		[BsonElement("item")]
		public List<ItemDocument> Item { get; set; } = new List<ItemDocument>();
		[BsonRequired()]
		[BsonElement("hasFile")]
		public bool HasFile { get; private set; }
		[BsonRequired()]
		[BsonElement("numberFilePages")]
		public int NumberFilePages { get; private set; }
		[BsonRequired()]
		[BsonElement("expirationDate")]
		public DateTime ExpirationDate { get; private set; }


	}
}
