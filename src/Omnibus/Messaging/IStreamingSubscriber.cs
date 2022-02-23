using System;
using System.Threading.Tasks;

namespace Omnibus.Messaging
{
    public interface IStreamingSubscriber
    {
        Task SubscribeAsync<T>(string topicName, Action<T> handler) where T : class;
    }
}
