using Socoro.Application.Features.Customers.Commands;
using Socoro.Application.DTOs.Customer;
using Socoro.Web.Areas.Shared.Models;
using AutoMapper;

namespace Socoro.Web.Areas.Shared.Mappings
{
    internal class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CreateCustomer, CustomerViewModel>().ReverseMap();
            CreateMap<CustomerResponse, CustomerViewModel>().ReverseMap();
        }
    }
}
