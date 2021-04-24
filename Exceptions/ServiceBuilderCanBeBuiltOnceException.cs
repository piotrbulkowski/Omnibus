using System;

namespace Omnibus.Exceptions
{
    internal class ServiceBuilderCanBeBuiltOnceException : InvalidOperationException
    {
        public ServiceBuilderCanBeBuiltOnceException() : base("Build for OmnibusServiceBuilder can be called only once")
        {

        }
    }
}
