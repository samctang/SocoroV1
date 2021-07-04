using Socoro.Application.Interfaces.Repositories;
using AspNetCoreHero.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Socoro.Application.Features.Operations.Commands.Delete
{
    public class DeleteOperationCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }

        public class DeleteOperationCommandHandler : IRequestHandler<DeleteOperationCommand, Result<int>>
        {
            private readonly IOperationRepository _operationRepository;
            private readonly IUnitOfWork _unitOfWork;

            public DeleteOperationCommandHandler(IOperationRepository operationRepository, IUnitOfWork unitOfWork)
            {
                _operationRepository = operationRepository;
                _unitOfWork = unitOfWork;
            }

            public async Task<Result<int>> Handle(DeleteOperationCommand command, CancellationToken cancellationToken)
            {
                var operation = await _operationRepository.GetByIdAsync(command.Id);
                await _operationRepository.DeleteAsync(operation);
                await _unitOfWork.Commit(cancellationToken);
                return Result<int>.Success(operation.Id);
            }
        }
    }
}