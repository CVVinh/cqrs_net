using AutoMapper;
using BE_CQRS.Application.DTOs.Command.CreateCommand.Postgre;
using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models.Entities.Core;
using MediatR;

namespace BE_CQRS.Application.DTOs.Handlers.CreateHandlers.Postgre
{
    public class CreateTypeUnitHandler : IRequestHandler<CreateTypeUnitCommand, TypeUnitPg>
    {
        private readonly ITypeUnitPg _typeUnitRepo;
        private readonly IMapper _mapper;

        public CreateTypeUnitHandler(ITypeUnitPg typeUnitRepo, IMapper mapper)
        {
            _typeUnitRepo = typeUnitRepo;
            _mapper = mapper;
        }

        public async Task<TypeUnitPg> Handle(CreateTypeUnitCommand request, CancellationToken cancellationToken)
        {
            var mapData = _mapper.Map<TypeUnitPg>(request);
            mapData.DateCreated = DateTime.Now;
            mapData.IsDeleted = false;
            await _typeUnitRepo.Insert(mapData);
            return mapData;
        }


    }
}
