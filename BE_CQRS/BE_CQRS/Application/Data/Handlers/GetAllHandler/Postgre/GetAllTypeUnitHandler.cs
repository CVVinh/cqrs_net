using AutoMapper;
using BE_CQRS.Application.Data.Queries.GetAllQuery.Postgre;
using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models.Entities.Core;
using MediatR;

namespace BE_CQRS.Application.Data.Handlers.GetAllHandler.Postgre
{
    public class GetAllTypeUnitHandler : IRequestHandler<GetAllTypeUnitQuery, IEnumerable<TypeUnit>>
    {
        private readonly ITypeUnit _typeUnitRepo;
        private readonly IMapper _mapper;

        public GetAllTypeUnitHandler(ITypeUnit typeUnitRepo, IMapper mapper)
        {
            _typeUnitRepo = typeUnitRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TypeUnit>> Handle(GetAllTypeUnitQuery request, CancellationToken cancellationToken)
        {
            return await _typeUnitRepo.GetAll();
        }


    }
}
