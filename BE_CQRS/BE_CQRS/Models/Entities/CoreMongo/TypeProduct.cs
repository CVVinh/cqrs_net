using MongoDB.Bson.Serialization.Attributes;

namespace BE_CQRS.Models.Entities.CoreMongo
{
    public class TypeProduct : BaseEntityMongo
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("TypeUnitId")]
        public int TypeUnitId { get; set; }

        [BsonElement("Product")]
        public List<Product> Product { get; set; }

        [BsonElement("InformationTypeProduct")]
        public List<InformationTypeProduct> InformationTypeProduct { get; set; }

    }
}
