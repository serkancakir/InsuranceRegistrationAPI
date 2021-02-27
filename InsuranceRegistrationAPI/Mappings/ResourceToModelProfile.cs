using AutoMapper;
using InsuranceRegistrationAPI.DTO;
using InsuranceRegistrationAPI.Models;

namespace InsuranceRegistrationAPI.Mappings
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<CustomerDTO, Customer>();
            CreateMap<Customer, CustomerDTO>();
        }
    }
}
