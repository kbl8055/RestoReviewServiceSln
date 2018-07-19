using RestoReviewService.Business;
using System.Collections.Generic;

namespace RestoReviewService.Repository.Interface
{
    public interface IRepositoryRestaurant : IRepository<Restaurant>
    {
        // Add signature methods here to extend the generic interface
        IEnumerable<Restaurant> GetRestaurantByCity(string cityName);
    }
}
