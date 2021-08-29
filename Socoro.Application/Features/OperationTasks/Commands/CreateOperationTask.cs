using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Socoro.Application.Features.OperationTasks.Commands
{
    public partial class CreateOperationTask : IRequest<Result<int>>
    {
        public string Note { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Status { get; set; }
        public int OperationProcessId { get; set; }
    }
    public class CreateOperationTaskHandler : IRequestHandler<CreateOperationTask, Result<int>>
    {
        private readonly IOperationTaskRepository _operationTaskRepository;
        private readonly IMapper _mapper;

        private IUnitOfWork _unitOfWork { get; set; }

        public CreateOperationTaskHandler(IOperationTaskRepository operationTaskRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _operationTaskRepository = operationTaskRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateOperationTask request, CancellationToken cancellationToken)
        {
            var operationTask = _mapper.Map<OperationTask>(request);
            await _operationTaskRepository.InsertAsync(operationTask);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(operationTask.Id);
        }
    }
}
