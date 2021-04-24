using System.Threading.Tasks;

namespace Omnibus.CQRS
{
    public interface ICommandHandler
    {
        public interface ICommandHandler<in TCommand> where TCommand : ICommand
        {
            Task HandleAsync(TCommand command);
        }
        public interface ICommandHandler<in TCommand, TResult> where TCommand : ICommand<TResult>
        {
            Task<TResult> HandleAsync(TCommand command);
        }
    }
}
