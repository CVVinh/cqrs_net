using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models.Entities.Core;
using BE_CQRS.Models;

namespace BE_CQRS.Repository.RepositoryPostgre
{
    public class TypeUnitRepo : PostgreRepository<TypeUnit>, ITypeUnit
    {
        public TypeUnitRepo(PostgreDbContext context) : base(context) { }

    }
}
