using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models;
using BE_CQRS.Models.Entities.Core;

namespace BE_CQRS.Repository.RepositoryPostgre
{
    public class DetailInformationTypeProductRepo : PostgreRepository<DetailInformationTypeProduct>, IDetailInformationTypeProduct
    {
        public DetailInformationTypeProductRepo(PostgreDbContext context) : base(context) 
        {
        }

    }
}
