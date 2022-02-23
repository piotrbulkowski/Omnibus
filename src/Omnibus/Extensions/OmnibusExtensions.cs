using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Omnibus.Extensions
{
    public static class OmnibusExtensions
    {
        public static IOmnibusServicesBuilder AddOmnibus(this IServiceCollection services)
        {
            var builder = new OmnibusServiceBuilder(services);

            return builder;
        }
    }
}
