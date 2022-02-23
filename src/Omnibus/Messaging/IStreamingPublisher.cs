using System.Threading.Tasks;

namespace Omnibus.Messaging
{
    public interface IStreamingPublisher
    {
        Task PublishAsync<T>(string topicName, T data, bool isFireAndForget = false) where T : class;
    }
}
