using System.ComponentModel;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using WCF_REST_Service_With_No_Svc.Models;

namespace WCF_REST_Service_With_No_Svc
{
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class DataService
    {
        [WebGet(UriTemplate = "/Data", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        [Description("This API call returns some Data.")]
        public virtual User GetData()
        {
            return new User
            {
                UserId = 1,
                Username = "johnd",
                FirstName = "John",
                LastName = "Doe",
                Email = "johnd@gmail.com",
                Password = "1GoodPassword!"
            };
        }

        [WebInvoke(UriTemplate = "/Data", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
            Method = "POST")]
        [Description("This API call posts some data to server.")]
        public virtual string PostData(User user)
        {
            return
                string.Format(
                    "UserId = {0}, Username = {1}, FirstName = {2}, LastName = {3}, Email = {4}, Password = {5}",
                    user.UserId, user.Username, user.FirstName, user.LastName, user.Email, user.Password);
        }
    }
}