using RestoReviewService.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace RestoReviewService.Repository
{
    public class Lookup<TEntity> : ILookup<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;

        public Lookup(DbContext context) => _context = context;

        public IEnumerable<TEntity> GetAll() => _context.Set<TEntity>().ToList();

        public TEntity GetById(int Id) => _context.Set<TEntity>().Find(Id);
        //public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) => _context.Set<TEntity>().Where(predicate);
    }
}