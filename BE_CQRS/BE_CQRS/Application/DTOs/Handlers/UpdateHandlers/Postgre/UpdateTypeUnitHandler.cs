using AutoMapper;
using BE_CQRS.Application.DTOs.Command.UpdateCommand.Postgre;
using BE_CQRS.Interface.InterfaceModel;
using BE_CQRS.Models.Entities.Core;
using MediatR;

namespace BE_CQRS.Application.DTOs.Handlers.UpdateHandlers.Postgre
{
    public class UpdateTypeUnitHandler : IRequestHandler<UpdateTypeUnitCommand, bool>
    {
        private readonly ITypeUnit _typeUnitRepo;
        private readonly IMapper _mapper;

        public UpdateTypeUnitHandler(ITypeUnit typeUnitRepo, IMapper mapper)
        {
            _typeUnitRepo = typeUnitRepo;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateTypeUnitCommand request, CancellationToken cancellationToken)
        {
            var existingEntity = await _typeUnitRepo.GetById(s => s.Id.Equals(request.Id));
            if (existingEntity == null)
            {
                return false;
            }
            var mapData = _mapper.Map(request, existingEntity);
            mapData.DateUpdated = DateTime.Now;
            await _typeUnitRepo.Update(mapData);
            return true;
        }


    }
}
