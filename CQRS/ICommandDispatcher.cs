using System.Threading.Tasks;

namespace Omnibus.CQRS
{
    public interface ICommandDispatcher
    {
        Task SendAsync<T>(T command) where T : ICommand;
    }
}
