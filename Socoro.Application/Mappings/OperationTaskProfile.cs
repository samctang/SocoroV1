using Socoro.Application.DTOs.Operation;
using Socoro.Domain.Entities;
using AutoMapper;
using Socoro.Application.Features.OperationTasks.Commands;

namespace Socoro.Application.Mappings
{
    internal class OperationTaskProfile : Profile
    {
        public OperationTaskProfile()
        {
            CreateMap<CreateOperationTask, OperationTask>().ReverseMap();
            CreateMap<OperationTaskResponse, OperationTask>().ReverseMap();
        }
    }
}
