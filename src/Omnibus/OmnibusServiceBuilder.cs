using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Omnibus.Exceptions;
using System;

namespace Omnibus
{
    /// <summary>
    /// Main class responsible for Omnibus ServiceBuilder
    /// </summary>
    public sealed class OmnibusServiceBuilder : IOmnibusServicesBuilder
    {
        private readonly IServiceCollection _services;
        IServiceCollection IOmnibusServicesBuilder.Services
            => _services;
        public IConfiguration Configuration { get; }

        private bool _isBuilt = false;

        public OmnibusServiceBuilder(IServiceCollection services, IConfiguration configuration = null)
        {
            _services = services;
            Configuration = configuration;
        }

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

            return provider;
        }
    }
}
