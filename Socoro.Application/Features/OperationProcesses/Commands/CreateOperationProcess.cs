using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Socoro.Application.Features.OperationProcesses.Commands
{
    public partial class CreateOperationProcess : IRequest<Result<int>>
    {
        public int TypeId { get; set; }
        public string Status { get; set; }
        public int OperationId { get; set; }
    }
    public class CreateOperationProcessHandler : IRequestHandler<CreateOperationProcess, Result<int>>
    {
        private readonly IOperationProcessRepository _operationProcessRepository;
        private readonly IMapper _mapper;

        private IUnitOfWork _unitOfWork { get; set; }

        public CreateOperationProcessHandler(IOperationProcessRepository operationProcessRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _operationProcessRepository = operationProcessRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateOperationProcess request, CancellationToken cancellationToken)
        {
            var operationProcess = _mapper.Map<OperationProcess>(request);
            await _operationProcessRepository.InsertAsync(operationProcess);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(operationProcess.Id);
        }
    }
}
