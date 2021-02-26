using InsuranceRegistrationAPI.Models;
using InsuranceRegistrationAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceRegistrationAPI.Controllers
{
    [Route("api")]
    public class RegistrationController : Controller
    {
        private readonly ICustomerService _customerService;
        public RegistrationController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public string Get()
        {
            return "Running...";
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register([FromBody] Customer customerInformation)
        {
            var result = _customerService.CreateCustomer(customerInformation);

            return Ok(result.CustomerId);
        }
    }
}
