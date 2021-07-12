using Socoro.Application.Features.Customers.Commands.Create;
using Socoro.Application.Features.Customers.Queries.GetByCompanyId;
using Socoro.Web.Areas.Shared.Models;
using AutoMapper;

namespace Socoro.Web.Areas.Shared.Mappings
{
    internal class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CreateCustomerCommand, CustomerViewModel>().ReverseMap();
            CreateMap<GetCustomersByCompanyIdResponse, CustomerViewModel>().ReverseMap();
        }
    }
}
