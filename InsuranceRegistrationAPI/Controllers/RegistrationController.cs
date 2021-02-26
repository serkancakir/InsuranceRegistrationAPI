using Microsoft.AspNetCore.Mvc;

namespace InsuranceRegistrationAPI.Controllers
{
    [Route("api")]
    public class RegistrationController : Controller
    {
        public RegistrationController()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "Running...";
        }
    }
}
