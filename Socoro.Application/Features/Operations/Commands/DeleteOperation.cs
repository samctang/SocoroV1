using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Socoro.Application.Features.Operations.Commands
{
    public class DeleteOperation : IRequest<Result<int>>
    {
        public int Id { get; set; }
    }
    public class DeleteOperationHandler : IRequestHandler<DeleteOperation, Result<int>>
    {
        private readonly IOperationRepository _operationRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteOperationHandler(IOperationRepository operationRepository, IUnitOfWork unitOfWork)
        {
            _operationRepository = operationRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<int>> Handle(DeleteOperation command, CancellationToken cancellationToken)
        {
            var operation = await _operationRepository.GetByIdAsync(command.Id);
            await _operationRepository.DeleteAsync(operation);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(operation.Id);
        }
    }
}