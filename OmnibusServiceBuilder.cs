using Microsoft.Extensions.DependencyInjection;
using Omnibus.Exceptions;
using System;

namespace Omnibus
{
    public class OmnibusServiceBuilder : IOmnibusServicesBuilder
    {
        private readonly IServiceCollection _services;
        IServiceCollection IOmnibusServicesBuilder.Services
            => _services;

        private bool _isBuilt = false;

        /// <summary>
        /// Create a new services container for the omnibus services registrations.
        /// </summary>
        public IServiceProvider Build()
        {
            if (_isBuilt)
            {
                throw new ServiceBuilderCanBeBuiltOnceException();
            }
            var provider = _services.BuildServiceProvider();

            _isBuilt = true;
        }
    }
}
