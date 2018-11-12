using System;
using Microsoft.Extensions.DependencyInjection;

namespace PacktDIExamples.Common
{
    public interface IModuleRegistrar
    {
        void Add(Type serviceType, Type implementationType, ServiceLifetime lifetime);
    }
}
