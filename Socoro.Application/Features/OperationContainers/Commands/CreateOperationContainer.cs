using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Socoro.Application.Features.OperationContainers.Commands
{
    public partial class CreateOperationContainer : IRequest<Result<int>>
    {
        public int TypeId { get; set; }
        public int GrossWeight { get; set; }
        public string CommercialDescription { get; set; }
        public bool Hazardous { get; set; }
        public string HazardClass { get; set; }
        public int UNCode { get; set; }
        public string OperationContainerNo { get; set; }
        public string SealNo { get; set; }
        public int TareWeight { get; set; }
    }

    public class CreateOperationContainerHandler : IRequestHandler<CreateOperationContainer, Result<int>>
    {
        private readonly IOperationContainerRepository _OperationContainerRepository;
        private readonly IMapper _mapper;

        private IUnitOfWork _unitOfWork { get; set; }

        public CreateOperationContainerHandler(IOperationContainerRepository OperationContainerRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _OperationContainerRepository = OperationContainerRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateOperationContainer request, CancellationToken cancellationToken)
        {
            var OperationContainer = _mapper.Map<OperationContainer>(request);
            await _OperationContainerRepository.InsertAsync(OperationContainer);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(OperationContainer.Id);
        }
    }
}
