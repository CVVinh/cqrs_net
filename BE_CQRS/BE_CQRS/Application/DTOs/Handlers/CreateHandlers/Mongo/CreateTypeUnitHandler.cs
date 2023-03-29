using BE_CQRS.Application.DTOs.Command.CreateCommand.Mongo;
using BE_CQRS.Models.Entities.CoreMongo;
using BE_CQRS.Repository.RepositotyMongo;
using MediatR;

namespace BE_CQRS.Application.DTOs.Handlers.CreateHandlers.Mongo
{
    public class CreateTypeUnitHandler : IRequestHandler<CreateTypeUnitCommand, TypeUnitMg>
    {
        private readonly ITypeUnitRepo _typeUnitRepo;

        public CreateTypeUnitHandler(ITypeUnitRepo typeUnitRepo)
        {
            _typeUnitRepo = typeUnitRepo;
        }

        public async Task<TypeUnitMg> Handle(CreateTypeUnitCommand request, CancellationToken cancellationToken)
        {
            var objectTypeUnit = new TypeUnitMg
            {
                Name = request.Name,
                TypeProduct = request.TypeProduct,
                Unit = request.Unit,
            };

            return await _typeUnitRepo.Create(objectTypeUnit);
        }
    }
}
