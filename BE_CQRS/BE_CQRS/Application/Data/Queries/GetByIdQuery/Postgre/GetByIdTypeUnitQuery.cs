using BE_CQRS.Models.Entities.Core;
using MediatR;

namespace BE_CQRS.Application.Data.Queries.GetByIdQuery.Postgre
{
    public class GetByIdTypeUnitQuery : IRequest<TypeUnitPg>
    {
        public int Id { get; set; }
        public GetByIdTypeUnitQuery(int id)
        {
            Id = id;
        }
    }
}
