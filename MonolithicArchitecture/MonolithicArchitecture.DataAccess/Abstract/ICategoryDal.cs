using MonolithicArchitecture.DataAccess.Concrete.EntityFramework.GenericRepository;
using MonolithicArchitecture.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicArchitecture.DataAccess.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {

    }
}
