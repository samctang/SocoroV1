using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;
using System.Collections.Generic;

namespace Socoro.Application.Features.OperationTasks.Queries
{
    public class GetAllByOperationProcessId : IRequest<Result<List<OperationTaskResponse>>>
    {
        public int OperationProcessId { get; set; }
    }
    public class GetAllByOperationProcessIdHandler : IRequestHandler<GetAllByOperationProcessId, Result<List<OperationTaskResponse>>>
    {
        private readonly IOperationTaskRepository _operationTask;
        private readonly IMapper _mapper;

        public GetAllByOperationProcessIdHandler(IOperationTaskRepository operationTask, IMapper mapper)
        {
            _operationTask = operationTask;
            _mapper = mapper;
        }

        public async Task<Result<List<OperationTaskResponse>>> Handle(GetAllByOperationProcessId query, CancellationToken cancellationToken)
        {
            var operationTaskList = await _operationTask.GetAllByOperationProcessIdAsync(query.OperationProcessId);
            var mappedOperationTaskList = _mapper.Map<List<OperationTaskResponse>>(operationTaskList);
            return Result<List<OperationTaskResponse>>.Success(mappedOperationTaskList);
        }
    }
}