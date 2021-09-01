using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Socoro.Application.Features.OperationTasks.Commands
{
    public class UpdateOperationTask : IRequest<Result<int>>
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public DateTime DueDate { get; set; }
        public bool Status { get; set; }
    }
    public class UpdateOperationTaskHandler : IRequestHandler<UpdateOperationTask, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOperationTaskRepository _operationTaskTaskRepository;

        public UpdateOperationTaskHandler(IOperationTaskRepository operationTaskTaskRepository, IUnitOfWork unitOfWork)
        {
            _operationTaskTaskRepository = operationTaskTaskRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<int>> Handle(UpdateOperationTask command, CancellationToken cancellationToken)
        {
            var operationTask = await _operationTaskTaskRepository.GetByIdAsync(command.Id);

            if (operationTask == null)
            {
                return Result<int>.Fail($"Operation Not Found.");
            }
            else
            {
                operationTask.Note = command.Note;
                operationTask.DueDate = command.DueDate;
                operationTask.Status = command.Status;

                await _operationTaskTaskRepository.UpdateAsync(operationTask);
                await _unitOfWork.Commit(cancellationToken);
                return Result<int>.Success(operationTask.Id);
            }
        }
    }
}