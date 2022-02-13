using Microsoft.Extensions.DependencyInjection;
using System;

namespace Omnibus
{
    public interface IOmnibusServicesBuilder
    {
        IServiceProvider Build();
        internal IServiceCollection Services { get; }
    }
}
