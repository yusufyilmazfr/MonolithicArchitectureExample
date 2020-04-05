using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicArchitecture.DataAccess.Concrete.EntityFramework.GenericRepository
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        Task AddAsync(TEntity entity);
        void Remove(TEntity entity);
        List<TEntity> GetList();
    }
}
