using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models;
using BE_CQRS.Models.Entities.Core;

namespace BE_CQRS.Repository.RepositoryPostgre
{
    public class InformationProductRepoPg : PostgreRepository<InformationProductPg>, IInformationProductPg
    {
        public InformationProductRepoPg(PostgreDbContext context) : base(context) { }

    }
}
