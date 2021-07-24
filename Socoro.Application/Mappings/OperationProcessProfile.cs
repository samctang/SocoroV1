using Socoro.Application.Features.OperationProcesses.Commands;
using Socoro.Application.DTOs.Operation;
using Socoro.Domain.Entities;
using AutoMapper;
using Socoro.Application.Features.OperationProcesses.Queries;

namespace Socoro.Application.Mappings
{
    internal class OperationProcessProfile : Profile
    {
        public OperationProcessProfile()
        {
            CreateMap<CreateOperationProcess, OperationProcess>().ReverseMap();
            CreateMap<GetOperationProcessByOperationId, OperationProcess>().ReverseMap();
            CreateMap<OperationProcessResponse, OperationProcess>().ReverseMap();
        }

    }
}
