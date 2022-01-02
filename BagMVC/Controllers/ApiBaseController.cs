using ApiCountryLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BagMVC.Controllers
{
    public class ApiBaseController : Controller
    {
        protected ApiCountryClient client;
        public  ApiBaseController(IConfiguration configuration)
        {
            client = new ApiCountryClient(configuration.GetConnectionString("JsonBD"));
        }
    }
}
