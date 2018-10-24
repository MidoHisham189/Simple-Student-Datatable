using School.Domain.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace School.Domain.Concerte.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> 
        where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);

           
        }

        public void addRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
            
        }

        public IEnumerable<TEntity> find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().
                 Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();

        }

        public TEntity getById(int id)
        {
            return Context.Set<TEntity>()
                .Find(id);
        }

        public void remove(TEntity entity)
        {
            Context.Set<TEntity>()
                .Remove(entity);

           
        }

        public void removeRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>()
                .RemoveRange(entities);
        }

        public TEntity singleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
        

           
                 return Context.Set<TEntity>()
                .SingleOrDefault(predicate);
            
            
        }
    }
}
