using AutoMapper;
using BE_CQRS.Application.Data.Queries.GetByIdQuery.Postgre;
using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models.Entities.Core;
using MediatR;

namespace BE_CQRS.Application.Data.Handlers.GetByIdHandler.Postgre
{
    public class GetByIdTypeUnitHandler : IRequestHandler<GetByIdTypeUnitQuery, TypeUnit>
    {
        private readonly ITypeUnit _typeUnitRepo;
        private readonly IMapper _mapper;

        public GetByIdTypeUnitHandler(ITypeUnit typeUnitRepo, IMapper mapper)
        {
            _typeUnitRepo = typeUnitRepo;
            _mapper = mapper;
        }

        public async Task<TypeUnit> Handle(GetByIdTypeUnitQuery request, CancellationToken cancellationToken)
        {
            return await _typeUnitRepo.GetById(s => s.Id.Equals(request.Id));
        }

    }
}
