using BE_CQRS.Models.Entities.Core;

namespace BE_CQRS.Interface.InterfaceModel
{
    public interface IProductPg : IPostgreRepository<ProductPg>
    {
    }
}
