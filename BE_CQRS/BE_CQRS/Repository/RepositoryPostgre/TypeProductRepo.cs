using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models.Entities.Core;
using BE_CQRS.Models;

namespace BE_CQRS.Repository.RepositoryPostgre
{
    public class TypeProductRepo : PostgreRepository<TypeProduct>, ITypeProduct
    {
        public TypeProductRepo(PostgreDbContext context) : base(context) { }

    }
}
