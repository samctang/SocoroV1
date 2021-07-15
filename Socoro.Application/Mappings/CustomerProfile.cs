using Socoro.Application.Features.Customers.Commands;
using Socoro.Application.DTOs.Customer;
using AutoMapper;
using Socoro.Domain.Entities;

namespace Socoro.Application.Mappings
{
    internal class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CreateCustomer, Customer>().ReverseMap();
            CreateMap<CustomerResponse, Customer>().ReverseMap();
        }
    }
}
