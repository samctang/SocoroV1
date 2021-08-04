using Socoro.Application.Features.OperationContainers.Commands;
using Socoro.Application.DTOs.Operation;
using AutoMapper;
using Socoro.Domain.Entities;

namespace Socoro.Application.Mappings
{
    internal class OperationContainerProfile : Profile
    {
        public OperationContainerProfile()
        {
            CreateMap<CreateOperationContainer, OperationContainer>().ReverseMap();
            CreateMap<OperationContainerResponse, OperationContainer>().ReverseMap();
        }
    }
}
