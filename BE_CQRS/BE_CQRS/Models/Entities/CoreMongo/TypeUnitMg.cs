using BE_CQRS.Models.Entities.Core;
using MongoDB.Bson.Serialization.Attributes;

namespace BE_CQRS.Models.Entities.CoreMongo
{
    public class TypeUnitMg : BaseEntityMongo
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("TypeProduct")]
        public List<TypeProductMg> TypeProduct { get; set; }

        [BsonElement("Unit")]
        public List<UnitMg> Unit { get; set; }
    }
}
