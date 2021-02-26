using System;
using InsuranceRegistrationAPI.Models;
using InsuranceRegistrationAPI.Repositories;

namespace InsuranceRegistrationAPI.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer CreateCustomer(Customer customerInfo)
        {
            try
            {
                int customerId = BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0);
                customerInfo.CustomerId = Math.Abs(customerId);
                _customerRepository.AddCustomer(customerInfo);
                return customerInfo;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while saving the customer: {ex.Message}");
            }
        }
    }
}
