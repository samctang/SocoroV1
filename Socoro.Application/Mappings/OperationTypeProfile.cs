using Socoro.Application.Features.OperationTypes.Queries.GetAllOperationTypes;
using Socoro.Domain.Entities;
using AutoMapper;

namespace Socoro.Application.Mappings
{
    internal class OperationTypeProfile : Profile
    {
        public OperationTypeProfile()
        {
            CreateMap<GetAllOperationTypesCachedResponse, OperationType>().ReverseMap();
        }
    }
}
