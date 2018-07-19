using RestoReviewService.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoReviewService
{
    interface IUnitOfWork : IDisposable
    {
        IRepositoryRestaurant Restaurants { get; }
        IRepositoryIngredient Ingredients { get; }
        //ILookup<TEntity> Lookup : where TEntity : class { get; set; }  // How?
        int Persist();
    }
}
