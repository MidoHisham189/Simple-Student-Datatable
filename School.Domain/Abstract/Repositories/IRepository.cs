using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Abstract.Repositories
{
   public interface IRepository<TEntity> where TEntity : class
    {
        TEntity getById(int id);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> find(Expression<Func<TEntity, bool>> predicate);

        TEntity singleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);

        void addRange(IEnumerable<TEntity> entities);

        void remove(TEntity entity);
        void removeRange(IEnumerable<TEntity> entities);

    }
}
