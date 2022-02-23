using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
    }
}