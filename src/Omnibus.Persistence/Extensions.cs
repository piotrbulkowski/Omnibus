using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Omnibus.Messaging;
using Omnibus.Persistence.Streaming;
using Omnibus.Persistence.Types;
using StackExchange.Redis;

namespace Omnibus.Persistence
{
    public static class Extensions
    {
        private const string RedisSectionName = "redis";

        public static IOmnibusServicesBuilder AddRedis(
            this IOmnibusServicesBuilder builder, IConfiguration configuration)
        {
            var section = configuration.GetRequiredSection(RedisSectionName);
            var settings = new RedisSettings();

            section.Bind(settings);
            builder.Services
                .Configure<RedisSettings>(section)
                .AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(settings.ConnectionString));

            return builder;
        }

        // TODO: Implement AddStackExchangeRedisCache which will make this method an alternative to AddRedisStream
        public static IOmnibusServicesBuilder AddRedisCache(this IOmnibusServicesBuilder builder)
        {
            throw new NotImplementedException();
        }
        public static IOmnibusServicesBuilder AddRedisStream(this IOmnibusServicesBuilder builder)
        {
            builder.Services
                    .AddSingleton<IStreamingPublisher, RedisStreamingPublisher>()
                    .AddSingleton<IStreamingSubscriber, RedisStreamingSubscriber>();

            return builder;
        }
    }
}