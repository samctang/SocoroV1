using Socoro.Application.DTOs.Operation;
using Socoro.Domain.Entities;
using AutoMapper;

namespace Socoro.Application.Mappings
{
    internal class OperationTypeProfile : Profile
    {
        public OperationTypeProfile()
        {
            CreateMap<OperationTypeResponse, OperationType>().ReverseMap();
        }
    }
}
