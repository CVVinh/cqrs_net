using BE_CQRS.Models.Entities.Core;
using MediatR;

namespace BE_CQRS.Application.Data.Queries.GetAllQuery.Postgre
{
    public class GetAllTypeUnitQuery : IRequest<IEnumerable<TypeUnitPg>>
    {
    }
}
