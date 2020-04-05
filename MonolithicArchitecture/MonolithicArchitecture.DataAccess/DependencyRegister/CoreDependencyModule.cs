using Microsoft.Extensions.DependencyInjection;
using MonolithicArchitecture.DataAccess.Abstract;
using MonolithicArchitecture.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonolithicArchitecture.DataAccess.DependencyRegister
{
    public class CoreDependencyModule
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddSingleton<ICategoryDal, EfCategoryDal>();
        }
    }
}
