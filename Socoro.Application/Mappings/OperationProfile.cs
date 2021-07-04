using Socoro.Application.Features.Operations.Commands.Create;
using Socoro.Application.Features.Operations.Queries.GetAllCached;
using Socoro.Application.Features.Operations.Queries.GetAllPaged;
using Socoro.Application.Features.Operations.Queries.GetById;
using Socoro.Domain.Entities;
using AutoMapper;

namespace Socoro.Application.Mappings
{
    internal class OperationProfile : Profile
    {
        public OperationProfile()
        {
            CreateMap<CreateOperationCommand, Operation>().ReverseMap();
            CreateMap<GetOperationByIdResponse, Operation>().ReverseMap();
            CreateMap<GetAllOperationsCachedResponse, Operation>().ReverseMap();
            CreateMap<GetAllOperationsResponse, Operation>().ReverseMap();
        }
    }
}