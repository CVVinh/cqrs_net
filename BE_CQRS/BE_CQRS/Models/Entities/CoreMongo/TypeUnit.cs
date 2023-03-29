using BE_CQRS.Models.Entities.Core;
using MongoDB.Bson.Serialization.Attributes;

namespace BE_CQRS.Models.Entities.CoreMongo
{
    public class TypeUnit : BaseEntityMongo
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("TypeProduct")]
        public List<TypeProduct> TypeProduct { get; set; }

        [BsonElement("Unit")]
        public List<Unit> Unit { get; set; }
    }
}
