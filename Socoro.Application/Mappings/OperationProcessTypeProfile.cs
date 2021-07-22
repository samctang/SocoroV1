using Socoro.Application.DTOs.Operation;
using Socoro.Domain.Entities;
using AutoMapper;

namespace Socoro.Application.Mappings
{
    internal class OperationProcessTypeProfile : Profile
    {
        public OperationProcessTypeProfile()
        {
            CreateMap<OperationProcessTypeResponse, OperationProcessType>().ReverseMap();
        }
    }
}
