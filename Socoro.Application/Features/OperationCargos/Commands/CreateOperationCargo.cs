using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Socoro.Application.Features.OperationCargos.Commands
{
    public partial class CreateOperationCargo : IRequest<Result<int>>
    {
        public string LoadingAddress { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public DateTime LoadingDate { get; set; }
        public TimeSpan LoadingTime { get; set; }
        public string Reference { get; set; }
        public int EIN { get; set; }
        public bool Bonded { get; set; }
        public bool Propelled { get; set; }
        public int NoContainers { get; set; }
        public int OperationId { get; set; }
    }

    public class CreateOperationCargoHandler : IRequestHandler<CreateOperationCargo, Result<int>>
    {
        private readonly IOperationCargoRepository _OperationCargoRepository;
        private readonly IMapper _mapper;

        private IUnitOfWork _unitOfWork { get; set; }

        public CreateOperationCargoHandler(IOperationCargoRepository OperationCargoRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _OperationCargoRepository = OperationCargoRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateOperationCargo request, CancellationToken cancellationToken)
        {
            var OperationCargo = _mapper.Map<OperationCargo>(request);
            await _OperationCargoRepository.InsertAsync(OperationCargo);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(OperationCargo.Id);
        }
    }
}
