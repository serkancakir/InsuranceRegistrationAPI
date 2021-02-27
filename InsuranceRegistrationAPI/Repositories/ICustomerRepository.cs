using InsuranceRegistrationAPI.Models;

namespace InsuranceRegistrationAPI.Repositories
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
    }
}
