using InsuranceRegistrationAPI.Contexts;
using InsuranceRegistrationAPI.Models;

namespace InsuranceRegistrationAPI.Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(AppDbContext context) : base(context) { }

        public void AddCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }
    }
}
