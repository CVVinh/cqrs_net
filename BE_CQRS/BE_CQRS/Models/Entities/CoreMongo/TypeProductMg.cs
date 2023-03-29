using MongoDB.Bson.Serialization.Attributes;

namespace BE_CQRS.Models.Entities.CoreMongo
{
    public class TypeProductMg : BaseEntityMongo
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("TypeUnitId")]
        public int TypeUnitId { get; set; }

        [BsonElement("Product")]
        public List<ProductMg> Product { get; set; }

        [BsonElement("InformationTypeProduct")]
        public List<InformationTypeProductMg> InformationTypeProduct { get; set; }

    }
}
