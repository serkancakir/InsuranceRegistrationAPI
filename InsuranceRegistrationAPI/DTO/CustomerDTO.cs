using System;
using System.ComponentModel.DataAnnotations;
using InsuranceRegistrationAPI.Utils;

namespace InsuranceRegistrationAPI.DTO
{
    public class CustomerDTO
    {
        public CustomerDTO()
        {
        }

        public int CustomerId { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string CustomerSurname { get; set; }

        [Required]
        [RegularExpression("[A-Z]{2,2}-[0-9]{6}")]
        public string PolicyReferenceNumber { get; set; }

        [MinimumAge(18)]
        public DateTime DateOfBirth { get; set; }

        [RegularExpression("[a-z0-9_.-]{4,}@[a-z0-9_.-]{2,}[/.co.uk/.com]")]
        public string Email { get; set; }
    }
}
