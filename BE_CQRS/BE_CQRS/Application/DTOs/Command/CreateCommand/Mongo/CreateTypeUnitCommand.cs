using BE_CQRS.Models.Entities.CoreMongo;
using MediatR;

namespace BE_CQRS.Application.DTOs.Command.CreateCommand.Mongo
{
    public class CreateTypeUnitCommand : IRequest<TypeUnit>
    {
        public string Name { get; set; }
        public List<TypeProduct> TypeProduct { get; set; }
        public List<Models.Entities.CoreMongo.Unit> Unit { get; set; }

       

    }
}
