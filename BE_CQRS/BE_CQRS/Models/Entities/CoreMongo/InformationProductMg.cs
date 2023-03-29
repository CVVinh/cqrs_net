using BE_CQRS.Models.Entities.Core;
using MongoDB.Bson.Serialization.Attributes;

namespace BE_CQRS.Models.Entities.CoreMongo
{
    public class InformationProductMg : BaseEntityMongo
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Description")]
        public string? Description { get; set; }

        [BsonElement("InformationTypeProduct")]
        public List<InformationTypeProductMg> InformationTypeProduct { get; set; }
    }
}
