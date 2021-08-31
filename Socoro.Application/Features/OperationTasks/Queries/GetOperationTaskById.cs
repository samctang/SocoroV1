using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;

namespace Socoro.Application.Features.OperationTaskTasks.Queries
{
    public class GetOperationTaskById : IRequest<Result<OperationTaskResponse>>
    {
        public int Id { get; set; }
    }
    public class GetOperationTaskByIdHandler : IRequestHandler<GetOperationTaskById, Result<OperationTaskResponse>>
    {
        private readonly IOperationTaskRepository _operationTaskRepository;
        private readonly IMapper _mapper;

        public GetOperationTaskByIdHandler(IOperationTaskRepository operationCache, IMapper mapper)
        {
            _operationTaskRepository = operationCache;
            _mapper = mapper;
        }

        public async Task<Result<OperationTaskResponse>> Handle(GetOperationTaskById query, CancellationToken cancellationToken)
        {
            var operation = await _operationTaskRepository.GetByIdAsync(query.Id);
            var mappedOperationTask = _mapper.Map<OperationTaskResponse>(operation);
            return Result<OperationTaskResponse>.Success(mappedOperationTask);
        }
    }
}