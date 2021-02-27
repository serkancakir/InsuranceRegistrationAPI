using System;
using InsuranceRegistrationAPI.Contexts;
using InsuranceRegistrationAPI.Models;

namespace InsuranceRegistrationAPI.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private AppDbContext _context;
        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }
    }
}
