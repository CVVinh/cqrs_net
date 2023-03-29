using MongoDB.Bson.Serialization.Attributes;

namespace BE_CQRS.Models.Entities.CoreMongo
{
    public class Unit : BaseEntityMongo
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("StanderNumber")]
        public int StanderNumber { get; set; } // hằng đơn vị chuẩn

        [BsonElement("TypeUnitId")]
        public int TypeUnitId { get; set; }

        [BsonElement("ProductUnit")]
        public List<ProductUnit> ProductUnit { get; set; }
    }
}
