using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestoReviewService.Repository.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // Retrieval methods
        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        // Add methods
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        // Remove methods
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
