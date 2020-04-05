using MonolithicArchitecture.DataAccess.Abstract;
using MonolithicArchitecture.DataAccess.Concrete.Context;
using MonolithicArchitecture.DataAccess.Concrete.EntityFramework.GenericRepository;
using MonolithicArchitecture.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicArchitecture.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfBaseRepository<Category,MyDbContext>, ICategoryDal
    {

    }
}
