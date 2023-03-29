using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models.Entities.Core;
using BE_CQRS.Models;

namespace BE_CQRS.Repository.RepositoryModel
{
    public class ProductUnitRepo : PostgreRepository<ProductUnit>, IProductUnit
    {
        public ProductUnitRepo(PostgreDbContext context) : base(context) { }

    }
}
