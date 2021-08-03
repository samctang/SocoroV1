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
    public class GetOperationProcessByOperationId : IRequest<Result<List<OperationProcessResponse>>>
    {
        public int OperationId { get; set; }
    }
    public class GetOperationProcessByOperationIdHandler : IRequestHandler<GetOperationProcessByOperationId, Result<List<OperationProcessResponse>>>
    {
        private readonly IOperationProcessRepository _operationProcess;
        private readonly IMapper _mapper;

        public GetOperationProcessByOperationIdHandler(IOperationProcessRepository operationProcess, IMapper mapper)
        {
            _operationProcess = operationProcess;
            _mapper = mapper;
        }

        public async Task<Result<List<OperationProcessResponse>>> Handle(GetOperationProcessByOperationId query, CancellationToken cancellationToken)
        {
            var operationProcessList = await _operationProcess.GetByOperationIdAsync(query.OperationId);
            var mappedOperationProcess = _mapper.Map<List<OperationProcessResponse>>(operationProcessList);
            return Result<List<OperationProcessResponse>>.Success(mappedOperationProcess);
        }
    }
}