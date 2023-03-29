using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models;
using BE_CQRS.Models.Entities.Core;

namespace BE_CQRS.Repository.RepositoryPostgre
{
    public class InformationProductRepo : PostgreRepository<InformationProduct>, IInformationProduct
    {
        public InformationProductRepo(PostgreDbContext context) : base(context) { }

    }
}
