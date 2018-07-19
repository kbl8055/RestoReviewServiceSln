using RestoReviewService.Business;
using RestoReviewService.Repository.Persistence;
using RestoReviewService.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestoReviewService.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceLookup" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceLookup.svc or ServiceLookup.svc.cs at the Solution Explorer and start debugging.
    public class ServiceLookup : IServiceLookup
    {
        public IEnumerable<Category> GetCategories()
        {
            IEnumerable<Category> categories;

            using (var uow = new UnitOfWork(new RestoContext()))
            {
                categories = uow.GetEntityList<Category>();
            }

            return categories;
        }

        public Category GetCategoryById(int id)
        {
            Category category;

            using (var uow = new UnitOfWork(new RestoContext()))
            {
                category = uow.GetEntityById<Category>(id);
            }

            return category;
        }
    }
}
