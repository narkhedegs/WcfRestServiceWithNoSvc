using System.ServiceModel.Activation;
using System.Web.Routing;

namespace WCF_REST_Service_With_No_Svc.App_Start
{
    public class RouteConfiguration
    {
        public static void RegisterRoutes()
        {
            var httpsOnlyWebServiceHostFactory = new HttpsOnlyWebServiceHostFactory();
            var webServiceHostFactory = new WebServiceHostFactory();

            RouteTable.Routes.Add(new ServiceRoute("UserService", httpsOnlyWebServiceHostFactory, typeof(UserService)));
            RouteTable.Routes.Add(new ServiceRoute("ProductService", webServiceHostFactory, typeof(ProductService)));
        }
    }
}