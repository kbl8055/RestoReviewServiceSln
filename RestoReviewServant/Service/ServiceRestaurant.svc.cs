using RestoReviewService.Business;
using RestoReviewService.Repository;
using RestoReviewService.Repository.Persistence;
using RestoReviewService.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestoReviewService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceRestaurant : IServiceRestaurant
    {
        public Restaurant GetResto(int value)
        {
            Restaurant resto;

            using (var uow = new UnitOfWork(new RestoContext()))
            {
                resto = uow.Restaurants.Get(value);
            }

            return resto;
        }

        public List<Restaurant> GetRestoInCity(string cityName)
        {
            List<Restaurant> restos;

            using (var uow = new UnitOfWork(new RestoContext()))
            {
                restos = uow.Restaurants.GetRestaurantByCity(cityName).ToList();
            }

            return restos;
        }

        public Restaurant RegisterResto(Restaurant resto)
        {
            if (resto == null)
            {
                throw new ArgumentNullException("Invalid resto information.");
            }

            using (var uow = new UnitOfWork(new RestoContext()))
            {
                uow.Restaurants.Add(resto);
                uow.Persist();
            }

            return resto;
        }
    }
}
