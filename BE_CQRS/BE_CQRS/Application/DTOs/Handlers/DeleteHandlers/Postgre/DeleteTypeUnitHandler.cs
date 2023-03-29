using AutoMapper;
using BE_CQRS.Application.DTOs.Command.DeleteCommand.Postgre;
using BE_CQRS.Interface.InterfaceModel;
using MediatR;

namespace BE_CQRS.Application.DTOs.Handlers.DeleteHandlers.Postgre
{
    public class DeleteTypeUnitHandler : IRequestHandler<DeleteTypeUnitCommand, bool>
    {
        private readonly ITypeUnitPg _typeUnitRepo;
        private readonly IMapper _mapper;

        public DeleteTypeUnitHandler(ITypeUnitPg typeUnitRepo, IMapper mapper)
        {
            _typeUnitRepo = typeUnitRepo;
            _mapper = mapper;
        }

        public async Task<bool> Handle(DeleteTypeUnitCommand request, CancellationToken cancellationToken)
        {
            var existingEntity = await _typeUnitRepo.GetById(s => s.Id.Equals(request.Id));
            if (existingEntity == null)
            {
                return false;
            }

            await _typeUnitRepo.Delete(existingEntity);
            return true;
        }


    }
}
