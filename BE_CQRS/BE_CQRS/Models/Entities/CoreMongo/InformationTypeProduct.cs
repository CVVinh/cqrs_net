using MongoDB.Bson.Serialization.Attributes;

namespace BE_CQRS.Models.Entities.CoreMongo
{
    public class InformationTypeProduct : BaseEntityMongo
    {
        [BsonElement("InformationProductId")]
        public int InformationProductId { get; set; }

        [BsonElement("TypeProductId")]
        public int TypeProductId { get; set; }

        [BsonElement("DetailInformationTypeProduct")]
        public List<DetailInformationTypeProduct> DetailInformationTypeProduct { get; set; }
    }
}
