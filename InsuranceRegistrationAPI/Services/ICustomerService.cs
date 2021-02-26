using InsuranceRegistrationAPI.Models;

namespace InsuranceRegistrationAPI.Services
{
    public interface ICustomerService
    {
        Customer CreateCustomer(Customer customerInfo);
    }
}
