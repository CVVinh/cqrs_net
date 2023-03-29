using BE_CQRS.Models.Entities.Core;
using MongoDB.Driver;

namespace BE_CQRS.Interface
{
    public interface IMongoDbContext
    {
        IMongoCollection<DetailInformationTypeProductPg> DetailInformationTypeProducts { get; set; }
        IMongoCollection<InformationProductPg> InformationProducts { get; set; }
        IMongoCollection<InformationTypeProductPg> InformationTypeProducts { get; set; }
        IMongoCollection<ProductPg> Products { get; set; }
        IMongoCollection<ProductUnitPg> ProductUnits { get; set; }
        IMongoCollection<TypeProductPg> TypeProducts { get; set; }
        IMongoCollection<TypeUnitPg> TypeUnits { get; set; }
        IMongoCollection<UnitPg> Units { get; set; }
    }
}
