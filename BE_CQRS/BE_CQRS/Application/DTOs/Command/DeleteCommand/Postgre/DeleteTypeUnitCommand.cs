using MediatR;

namespace BE_CQRS.Application.DTOs.Command.DeleteCommand.Postgre
{
    public class DeleteTypeUnitCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public DeleteTypeUnitCommand(int id)
        {
            Id = id;
        }
    }
}
