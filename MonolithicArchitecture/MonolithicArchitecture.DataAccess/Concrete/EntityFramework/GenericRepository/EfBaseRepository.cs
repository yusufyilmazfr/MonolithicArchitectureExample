using Microsoft.EntityFrameworkCore;
using MonolithicArchitecture.DataAccess.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicArchitecture.DataAccess.Concrete.EntityFramework.GenericRepository
{
    public class EfBaseRepository<TEntity, TContext>
        : IRepository<TEntity> where TEntity : class, new()
        where TContext : DbContext, new()

    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public Task AddAsync(TEntity entity)
        {
            return Task.Run(() =>
            {
                Add(entity);
            });
        }

        public List<TEntity> GetList()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public void Remove(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }
    }
}
