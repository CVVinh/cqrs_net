using MongoDB.Bson.Serialization.Attributes;

namespace BE_CQRS.Models.Entities.CoreMongo
{
    public class ProductUnitMg : BaseEntityMongo
    {
        [BsonElement("ProductId")]
        public int ProductId { get; set; }

        [BsonElement("UnitId")]
        public int UnitId { get; set; }
    }
}
