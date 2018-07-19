using RestoReviewService.Business;
using RestoReviewService.Repository.Interface;
using RestoReviewService.Repository.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace RestoReviewService.Repository
{
    public class RepositoryRestaurant : Repository<Restaurant>, IRepositoryRestaurant
    {
        public RestoContext RestoContext => _context as RestoContext;

        public RepositoryRestaurant(RestoContext context) : base(context)
        {

        }

        public IEnumerable<Restaurant> GetRestaurantByCity(string cityName)
            => RestoContext.Restos.Where(r => r.MainOffice.ToLower().Contains(cityName.ToLower() + " city")).ToList();
    }
}