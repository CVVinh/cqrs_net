using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BE_CQRS.Models.Entities
{
    public class BaseEntityMongo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        [BsonElement("IsDeleted")]
        public bool IsDeleted { get; set; } = false;

        [BsonElement("UserCreated")]
        public int? UserCreated { get; set; }

        [BsonElement("UserUpdated")]
        public int? UserUpdated { get; set; }

        [BsonElement("UserDeleted")]
        public int? UserDeleted { get; set; }

        [BsonElement("DateCreated")]
        public DateTime? DateCreated { get; set; }

        [BsonElement("DateUpdated")]
        public DateTime? DateUpdated { get; set; }

        [BsonElement("DateDeleted")]
        public DateTime? DateDeleted { get; set; }
    }
}
