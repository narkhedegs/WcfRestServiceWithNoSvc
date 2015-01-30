using System.ServiceModel.Activation;
using System.Web.Routing;

namespace WCF_REST_Service_With_No_Svc.App_Start
{
    public class RouteConfiguration
    {
        public static void RegisterRoutes()
        {
            var webServiceHostFactory = new WebServiceHostFactory();

            RouteTable.Routes.Add(new ServiceRoute("DataService", webServiceHostFactory, typeof(DataService)));
        }
    }
}