using System.Threading.Tasks;

namespace Omnibus.CQRS.Command
{
    public interface ICommandDispatcher
    {
        Task SendAsync<T>(T command) where T : ICommand;
    }
}
