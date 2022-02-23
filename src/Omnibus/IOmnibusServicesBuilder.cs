using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Omnibus
{
    public interface IOmnibusServicesBuilder
    {
        IServiceProvider Build();
        IServiceCollection Services { get; }
        IConfiguration Configuration { get; }
    }
}
