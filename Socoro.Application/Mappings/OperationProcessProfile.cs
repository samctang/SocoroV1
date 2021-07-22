using Socoro.Application.Features.OperationProcesses.Commands;
using Socoro.Application.DTOs.Operation;
using Socoro.Domain.Entities;
using AutoMapper;

namespace Socoro.Application.Mappings
{
    internal class OperationProcessProfile : Profile
    {
        public OperationProcessProfile()
        {
            CreateMap<CreateOperationProcess, OperationProcess>().ReverseMap();
            CreateMap<OperationResponse, OperationProcess>().ReverseMap();
        }

    }
}
