using RestoReviewService.Business;
using System.Collections.Generic;
using System.ServiceModel;

namespace RestoReviewService.Service.Interface
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceRestaurant
    {
        [OperationContract]
        Restaurant GetResto(int value);

        [OperationContract]
        Restaurant RegisterResto(Restaurant composite);

        [OperationContract]
        List<Restaurant> GetRestoInCity(string cityName);
    }
}
