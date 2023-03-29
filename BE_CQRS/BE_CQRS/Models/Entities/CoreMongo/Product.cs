using MongoDB.Bson.Serialization.Attributes;

namespace BE_CQRS.Models.Entities.CoreMongo
{
    public class Product : BaseEntityMongo
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Description")]
        public string? Description { get; set; }

        [BsonElement("Quantity")]
        public int Quantity { get; set; }

        [BsonElement("Price")]
        public int Price { get; set; }

        [BsonElement("TypeProductId")]
        public int TypeProductId { get; set; }

        [BsonElement("ProductUnit")]
        public List<ProductUnit> ProductUnit { get; set; }

        [BsonElement("DetailInformationTypeProduct")]
        public List<DetailInformationTypeProduct> DetailInformationTypeProduct { get; set; }

    }
}
