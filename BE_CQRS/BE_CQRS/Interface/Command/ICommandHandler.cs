using BE_CQRS.Interface.Command;

namespace BE_CQRS.Interface.Commands
{
    public interface ICommandHandler<TCommand, TResult>
    where TCommand : ICommand<TResult>
    {
        Task<TResult> HandleAsync(TCommand command, CancellationToken cancellationToken);
    }

}
