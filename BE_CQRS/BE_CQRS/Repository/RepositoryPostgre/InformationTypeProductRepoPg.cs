using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models.Entities.Core;
using BE_CQRS.Models;

namespace BE_CQRS.Repository.RepositoryPostgre
{
    public class InformationTypeProductRepoPg : PostgreRepository<InformationTypeProductPg>, IInformationTypeProductPg
    {
        public InformationTypeProductRepoPg(PostgreDbContext context) : base(context) { }

    }
}
