using BE_CQRS.Models.Entities.Core;
using MediatR;

namespace BE_CQRS.Application.DTOs.Command.CreateCommand.Postgre
{
    public class CreateTypeUnitCommand : IRequest<TypeUnit>
    {
        public string Name { get; set; }
        public int? UserCreated { get; set; }


        public CreateTypeUnitCommand()
        {
        }

        public CreateTypeUnitCommand(string name, int? userCreated)
        {
            Name = name;
            UserCreated = userCreated;
        }
    }
}
