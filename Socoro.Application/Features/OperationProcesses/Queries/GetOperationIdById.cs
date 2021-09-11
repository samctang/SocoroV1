using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;
using System.Collections.Generic;

namespace Socoro.Application.Features.OperationProcesses.Queries
{
    public class GetOperationIdById : IRequest<Result<OperationProcessResponse>>
    {
        public int Id { get; set; }
    }
    public class GetOperationIdByIdHandler : IRequestHandler<GetOperationIdById, Result<OperationProcessResponse>>
    {
        private readonly IOperationProcessRepository _operationProcess;
        private readonly IMapper _mapper;

        public GetOperationIdByIdHandler(IOperationProcessRepository operationProcess, IMapper mapper)
        {
            _operationProcess = operationProcess;
            _mapper = mapper;
        }

        public async Task<Result<OperationProcessResponse>> Handle(GetOperationIdById query, CancellationToken cancellationToken)
        {
            var operationProcessList = await _operationProcess.GetOperationIdById(query.Id);
            var mappedOperationProcess = _mapper.Map<OperationProcessResponse>(operationProcessList);
            return Result<OperationProcessResponse>.Success(mappedOperationProcess);
        }
    }
}