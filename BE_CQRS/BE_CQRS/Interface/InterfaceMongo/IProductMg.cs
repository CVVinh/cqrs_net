using BE_CQRS.Models.Entities.CoreMongo;

namespace BE_CQRS.Interface.InterfaceMongo
{
    public interface IProductMg : IMongoRepository<ProductMg>
    {
    }
}
