using Omnibus.Messaging;
using Omnibus.Serialization;
using StackExchange.Redis;

namespace Omnibus.Persistence.Streaming
{
    internal sealed class RedisStreamingSubscriber : IStreamingSubscriber
    {
        private readonly ISerializer _serializer;
        private readonly ISubscriber _subscriber;

        public RedisStreamingSubscriber(IConnectionMultiplexer connectionMultiplexer, ISerializer serializer)
        {
            _subscriber = connectionMultiplexer.GetSubscriber();
            _serializer = serializer;
        }
        public Task SubscribeAsync<T>(string topicName, Action<T> handler) where T : class
        {
            return _subscriber.SubscribeAsync(topicName, (_, data) =>
            {
                var payload = _serializer.Deserialize<T>(data);
                if (payload is null)
                {
                    return;
                }

                handler(payload);
            });
        } 
    }
}
