
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Infrastructure.Entities.Documents
{
	public abstract class BaseDocument
	{
		[BsonId]
		[BsonRepresentation(BsonType.String)]
		public ObjectId Id { get; set; }

	}
}
