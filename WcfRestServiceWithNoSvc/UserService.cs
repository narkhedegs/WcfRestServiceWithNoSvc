using System.ServiceModel;
using System.ServiceModel.Web;
using WcfRestServiceWithNoSvc.Models;

namespace WcfRestServiceWithNoSvc
{
    [ServiceContract]
    public class UserService
    {
        [WebGet(UriTemplate = "/Users/{UserId}", ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        public User Get(string userId)
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

        [WebInvoke(UriTemplate = "/Users", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
            Method = "POST")]
        public string Post(User user)
        {
            return
                string.Format(
                    "UserId = {0}, Username = {1}, FirstName = {2}, LastName = {3}, Email = {4}, Password = {5}",
                    user.UserId, user.Username, user.FirstName, user.LastName, user.Email, user.Password);
        }
    }
}