using System;
using WCF_REST_Service_With_No_Svc.App_Start;

namespace WCF_REST_Service_With_No_Svc
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfiguration.RegisterRoutes();
        }
    }
}