using System;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRegistrationAPI.Models
{
    public class Customer
    {
        public Customer()
        {
        }
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string PolicyReferenceNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
    }
}
