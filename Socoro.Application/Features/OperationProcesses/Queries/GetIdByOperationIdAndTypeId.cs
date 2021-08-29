using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;

namespace Socoro.Application.Features.OperationProcesses.Queries
{
    public class GetIdByOperationIdAndTypeId : IRequest<Result<OperationProcessResponse>>
    {
        public int OperationId { get; set; }
        public int TypeId { get; set; }
    }
    public class GetIdByOperationIdAndTypeIdHandler : IRequestHandler<GetIdByOperationIdAndTypeId, Result<OperationProcessResponse>>
    {
        private readonly IOperationProcessRepository _operationProcess;
        private readonly IMapper _mapper;

        public GetIdByOperationIdAndTypeIdHandler(IOperationProcessRepository operationProcess, IMapper mapper)
        {
            _operationProcess = operationProcess;
            _mapper = mapper;
        }

        public async Task<Result<OperationProcessResponse>> Handle(GetIdByOperationIdAndTypeId query, CancellationToken cancellationToken)
        {
            var operationProcess = await _operationProcess.GetIdByOperationIdAndTypeIdAsync(query.OperationId,query.TypeId);
            var mappedOperationProcess = _mapper.Map<OperationProcessResponse>(operationProcess);
            return Result<OperationProcessResponse>.Success(mappedOperationProcess);
        }
    }
}