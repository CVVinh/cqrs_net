using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models.Entities.Core;
using BE_CQRS.Models;

namespace BE_CQRS.Repository.RepositoryModel
{
    public class ProductUnitRepoPg : PostgreRepository<ProductUnitPg>, IProductUnitPg
    {
        public ProductUnitRepoPg(PostgreDbContext context) : base(context) { }

    }
}
