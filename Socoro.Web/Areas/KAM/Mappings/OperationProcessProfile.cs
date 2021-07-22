using Socoro.Application.Features.OperationProcesses.Commands;
using Socoro.Application.DTOs.Operation;
using AutoMapper;
using Socoro.Web.Areas.KAM.Models;

namespace Socoro.Web.Areas.KAM.Mappings
{
    internal class OperationProcessProfile : Profile
    {
        public OperationProcessProfile()
        {
            CreateMap<CreateOperationProcess, OperationProcessViewModel>().ReverseMap();
            CreateMap<OperationProcessResponse, OperationProcessViewModel>().ReverseMap();
        }
    }
}
