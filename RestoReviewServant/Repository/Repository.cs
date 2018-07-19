using RestoReviewService.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace RestoReviewService.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;

        // TODO: Add the necessary constructor here
        public Repository(DbContext context) => _context = context;

        public void Add(TEntity entity) => _context.Set<TEntity>().Add(entity);

        public void AddRange(IEnumerable<TEntity> entities) => _context.Set<TEntity>().AddRange(entities);

        // TODO: For review AsEnumerable() vs. AsEnumerable<T>(), present in Find and GetAll methods
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) => _context.Set<TEntity>().Where(predicate);

        public TEntity Get(int Id) => _context.Set<TEntity>().Find(Id);

        public IEnumerable<TEntity> GetAll() => _context.Set<TEntity>().ToList();

        public void Remove(TEntity entity) => _context.Set<TEntity>().Remove(entity);

        public void RemoveRange(IEnumerable<TEntity> entities) => _context.Set<TEntity>().RemoveRange(entities);
    }
}