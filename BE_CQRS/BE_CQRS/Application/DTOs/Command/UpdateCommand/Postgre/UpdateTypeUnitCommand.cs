using MediatR;

namespace BE_CQRS.Application.DTOs.Command.UpdateCommand.Postgre
{
    public class UpdateTypeUnitCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? UserUpdated { get; set; }


        public UpdateTypeUnitCommand()
        {
        }

        public UpdateTypeUnitCommand(string name, int? userUpdated)
        {
            Name = name;
            UserUpdated = userUpdated;
        }
    }
}
