using BE_CQRS.Models.Entities.CoreMongo;
using MediatR;

namespace BE_CQRS.Application.DTOs.Command.CreateCommand.Mongo
{
    public class CreateTypeUnitCommand : IRequest<TypeUnitMg>
    {
        public string Name { get; set; }
        public List<TypeProductMg> TypeProduct { get; set; }
        public List<Models.Entities.CoreMongo.UnitMg> Unit { get; set; }

       

    }
}
