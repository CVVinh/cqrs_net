using BE_CQRS.Interface.Command;
using BE_CQRS.Interface.Query;
using System.Windows.Input;

namespace BE_CQRS.Interface
{
    public interface IMediator
    {
        Task<TResult> SendAsync<TResult>(IQuery<TResult> query);
        Task SendAsync(ICommand command);
    }
}
