using RestoReviewService.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestoReviewService.Service.Interface
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceIngredient" in both code and config file together.
    [ServiceContract]
    public interface IServiceLookup
    {
        [OperationContract]
        IEnumerable<Category> GetCategories();

        [OperationContract]
        Category GetCategoryById(int id);
    }
}