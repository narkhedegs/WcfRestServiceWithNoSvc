using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace WCF_REST_Service_With_No_Svc
{
    public class HttpsOnlyWebServiceHostFactory : WebServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            var host = new WebServiceHost(serviceType, baseAddresses);

            foreach (var baseAddress in baseAddresses.Where(uri => uri.Scheme == Uri.UriSchemeHttps))
            {
                var binding = new WebHttpBinding(WebHttpSecurityMode.Transport);
                host.AddServiceEndpoint(
                    serviceType.GetInterfaces().Any() ? serviceType.GetInterfaces()[0] : serviceType, binding,
                    baseAddress);
            }

            return host;
        }
    }
}