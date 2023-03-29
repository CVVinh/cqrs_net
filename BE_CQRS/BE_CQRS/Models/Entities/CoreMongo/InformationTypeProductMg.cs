using MongoDB.Bson.Serialization.Attributes;

namespace BE_CQRS.Models.Entities.CoreMongo
{
    public class InformationTypeProductMg : BaseEntityMongo
    {
        [BsonElement("InformationProductId")]
        public int InformationProductId { get; set; }

        [BsonElement("TypeProductId")]
        public int TypeProductId { get; set; }

        [BsonElement("DetailInformationTypeProduct")]
        public List<DetailInformationTypeProductMg> DetailInformationTypeProduct { get; set; }
    }
}
