using BE_CQRS.Models.Entities.Core;
using MongoDB.Driver;

namespace BE_CQRS.Interface
{
    public interface IMongoDbContext
    {
        IMongoCollection<DetailInformationTypeProduct> DetailInformationTypeProducts { get; set; }
        IMongoCollection<InformationProduct> InformationProducts { get; set; }
        IMongoCollection<InformationTypeProduct> InformationTypeProducts { get; set; }
        IMongoCollection<Product> Products { get; set; }
        IMongoCollection<ProductUnit> ProductUnits { get; set; }
        IMongoCollection<TypeProduct> TypeProducts { get; set; }
        IMongoCollection<TypeUnit> TypeUnits { get; set; }
        IMongoCollection<Unit> Units { get; set; }
    }
}
