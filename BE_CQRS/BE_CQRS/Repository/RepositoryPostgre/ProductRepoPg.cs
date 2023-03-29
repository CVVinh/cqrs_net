using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models.Entities.Core;
using BE_CQRS.Models;

namespace BE_CQRS.Repository.RepositoryPostgre
{
    public class ProductRepoPg : PostgreRepository<ProductPg>, IProductPg
    {
        public ProductRepoPg(PostgreDbContext context) : base(context) { }

    }
}
