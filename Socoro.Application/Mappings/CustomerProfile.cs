using Socoro.Application.Features.Customers.Commands.Create;
using Socoro.Application.Features.Customers.Queries.GetByCompanyId;
using AutoMapper;
using Socoro.Domain.Entities;

namespace Socoro.Application.Mappings
{
    internal class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CreateCustomerCommand, Customer>().ReverseMap();
            CreateMap<GetCustomersByCompanyIdResponse, Customer>().ReverseMap();
        }
    }
}
