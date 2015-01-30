using System.ServiceModel;
using System.ServiceModel.Web;
using WCF_REST_Service_With_No_Svc.Models;

namespace WCF_REST_Service_With_No_Svc
{
    [ServiceContract]
    public class ProductService
    {
        [WebGet(UriTemplate = "/Products/{ProductId}", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        public Product Get(string productId)
        {
            return new Product
            {
                ProductId = 1,
                ProductName = "Oolong Tea"
            };
        }

        [WebInvoke(UriTemplate = "/Products", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json, Method = "POST")]
        public string Post(Product product)
        {
            return string.Format("ProductId = {0}, ProductName = {1}",
                product.ProductId, product.ProductName);
        }
    }
}