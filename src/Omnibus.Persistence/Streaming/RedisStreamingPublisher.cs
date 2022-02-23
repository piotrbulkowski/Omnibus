using Omnibus.Messaging;
using Omnibus.Serialization;
using StackExchange.Redis;

namespace Omnibus.Persistence.Streaming
{
    internal sealed class RedisStreamingPublisher : IStreamingPublisher
    {
        private readonly ISerializer _serializer;
        private readonly ISubscriber _subscriber;
        public RedisStreamingPublisher(IConnectionMultiplexer connectionMultiplexer, ISerializer serializer)
        {
            _subscriber = connectionMultiplexer.GetSubscriber();
            _serializer = serializer;
        }
        public Task PublishAsync<T>(string topicName, T data, bool isFireAndForget = false) where T : class
        {
            var payload = _serializer.Serialize(data);
            var flags = isFireAndForget ? CommandFlags.FireAndForget : CommandFlags.None;
            return _subscriber.PublishAsync(topicName, payload, flags);
        }
    }
}
