using BE_CQRS.Models.Entities.Core;
using MongoDB.Bson.Serialization.Attributes;

namespace BE_CQRS.Models.Entities.CoreMongo
{
    public class DetailInformationTypeProduct : BaseEntityMongo
    {
        [BsonElement("InformationTypeProductId")]
        public int InformationTypeProductId { get; set; }

        [BsonElement("ProductId")]
        public int ProductId { get; set; }

        [BsonElement("Content")]
        public string Content { get; set; }

        [BsonElement("Product")]
        public Product Product { get; set; }

        [BsonElement("InformationTypeProduct")]
        public InformationTypeProduct InformationTypeProduct { get; set; }
    }
}
