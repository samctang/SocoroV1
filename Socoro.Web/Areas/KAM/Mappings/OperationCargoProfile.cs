using Socoro.Application.Features.OperationCargos.Commands;
using Socoro.Application.DTOs.Operation;
using AutoMapper;
using Socoro.Web.Areas.KAM.Models;

namespace Socoro.Web.Areas.KAM.Mappings
{
    internal class OperationCargoProfile : Profile
    {
        public OperationCargoProfile()
        {
            CreateMap<CreateOperationCargo, OperationCargoViewModel>().ReverseMap();
            CreateMap<OperationCargoResponse, OperationCargoViewModel>().ReverseMap();
        }
    }
}
