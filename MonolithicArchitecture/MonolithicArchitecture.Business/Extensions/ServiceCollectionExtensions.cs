using Microsoft.Extensions.DependencyInjection;
using MonolithicArchitecture.DataAccess.DependencyRegister;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonolithicArchitecture.Business.DependencyRegister
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterCoreDependencies(this IServiceCollection services)
        {
            CoreDependencyModule.RegisterDependencies(services);
        }
    }
}
