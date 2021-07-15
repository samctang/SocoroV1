using Socoro.Application.Features.Operations.Commands;
using Socoro.Application.DTOs.Operation;
using Socoro.Domain.Entities;
using AutoMapper;

namespace Socoro.Application.Mappings
{
    internal class OperationProfile : Profile
    {
        public OperationProfile()
        {
            CreateMap<CreateOperation, Operation>().ReverseMap();
            CreateMap<UpdateOperation, Operation>().ReverseMap();
            CreateMap<DeleteOperation, Operation>().ReverseMap();
            CreateMap<OperationResponse, Operation>().ReverseMap();
        }
    }
}