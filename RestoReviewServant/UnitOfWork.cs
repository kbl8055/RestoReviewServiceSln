using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestoReviewService.Repository.Interface;
using RestoReviewService.Repository.Persistence;
using RestoReviewService.Repository;
using System.Data.Entity;
using RestoReviewService.Business;

namespace RestoReviewService
{
    // TODO: Should this class be declared "sealed"?
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RestoContext _restoContext;

        public UnitOfWork(RestoContext context)
        {
            _restoContext = context;
            Restaurants = new RepositoryRestaurant(_restoContext);
            Ingredients = new RepositoryIngredient(_restoContext);
        }

        public IRepositoryRestaurant Restaurants { get; private set; }
        public IRepositoryIngredient Ingredients { get; private set; }

        public IEnumerable<TEntity> GetEntityList<TEntity>() where TEntity : class
        {
            return new Lookup<TEntity>(_restoContext).GetAll();
        }

        public TEntity GetEntityById<TEntity>(int id) where TEntity : class
        {
            TEntity entityItem;

            entityItem = new Lookup<TEntity>(_restoContext).GetById(id);

            return entityItem;
        }

        public int Persist()
        {
            return _restoContext.SaveChanges();
        }

        public void Dispose()
        {
            _restoContext.Dispose();
        }
    }
}