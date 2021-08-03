using Socoro.Application.Features.OperationCargos.Commands;
using Socoro.Application.DTOs.Operation;
using AutoMapper;
using Socoro.Domain.Entities;

namespace Socoro.Application.Mappings
{
    internal class OperationCargoProfile : Profile
    {
        public OperationCargoProfile()
        {
            CreateMap<CreateOperationCargo, OperationCargo>().ReverseMap();
            CreateMap<OperationCargoResponse, OperationCargo>().ReverseMap();
        }
    }
}
