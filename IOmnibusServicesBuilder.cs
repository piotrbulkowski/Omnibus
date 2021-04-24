using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omnibus
{
    public interface IOmnibusServicesBuilder
    {
        IServiceProvider Build();
        internal IServiceCollection Services { get; }
    }
}
