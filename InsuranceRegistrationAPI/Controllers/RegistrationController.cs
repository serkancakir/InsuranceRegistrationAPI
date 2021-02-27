using AutoMapper;
using InsuranceRegistrationAPI.DTO;
using InsuranceRegistrationAPI.Models;
using InsuranceRegistrationAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceRegistrationAPI.Controllers
{
    [Route("api")]
    public class RegistrationController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public RegistrationController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        [HttpGet]
        public string Get()
        {
            return "Running...";
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register([FromBody] CustomerDTO customerInformation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Keys);
            }
            var customer = _mapper.Map<CustomerDTO, Customer>(customerInformation);
            var result = _customerService.CreateCustomer(customer);

            var categoryResource = _mapper.Map<Customer, CustomerDTO>(result);
            return Ok(categoryResource.CustomerId);
        }
    }
}
