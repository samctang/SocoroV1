using Socoro.Application.Features.OperationTasks.Commands;
using Socoro.Application.DTOs.Operation;
using AutoMapper;
using Socoro.Web.Areas.KAM.Models;

namespace Socoro.Web.Areas.KAM.Mappings
{
    internal class OperationTaskProfile : Profile
    {
        public OperationTaskProfile()
        {
            CreateMap<CreateOperationTask, OperationTaskViewModel>().ReverseMap();
            CreateMap<OperationTaskResponse, OperationTaskViewModel>().ReverseMap();
        }
    }
}
