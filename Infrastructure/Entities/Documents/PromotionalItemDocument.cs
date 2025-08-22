using Domain.Enums;
using Domain.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Entities.Documents
{
	[BsonCollection("PromotionalItem")]
	[BsonIgnoreExtraElements]
	public class PromotionalItemDocument : ItemDocument
	{
		public string MarketName { get; set; }
		public string CityName { get; set; }
		public PromotionalItemDocument()
		{
			
		}
		
		public PromotionalItemDocument(string marketName, string cityName, Item item)
		{
			Id = item.Id;
			MarketName = marketName;
			CityName = cityName;
			Name = item.Name;
			Description = item.Description;
			Type = item.Type;
			Price = item.Price;
			ExpirationDate = item.ExpirationDate;
		}
	}
}
