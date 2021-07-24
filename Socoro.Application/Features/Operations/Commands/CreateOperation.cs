using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Socoro.Application.Features.Operations.Commands
{
    public partial class CreateOperation : IRequest<Result<int>>
    {
        public string OperationNo { get; set; }
        public int TypeId { get; set; }
        public string Agent { get; set; }
        public string Shipper { get; set; }
        public string Consignee { get; set; }
        public string AgentRefNo { get; set; }
        public string ShipperRefNo { get; set; }
        public string ConsigneeRefNo { get; set; }
        public string PoL { get; set; }
        public string PoD { get; set; }
        public string OriginAddr1 { get; set; }
        public string OriginAddr2 { get; set; }
        public string OriginCity { get; set; }
        public string OriginState { get; set; }
        public string OriginZip { get; set; }
        public string OriginCountry { get; set; }
        public string DestinationAddr1 { get; set; }
        public string DestinationAddr2 { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationState { get; set; }
        public string DestinationZip { get; set; }
        public string DestinationCountry { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int Progress { get; set; }
        public string Status { get; set; }
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
    }

    public class CreateOperationHandler : IRequestHandler<CreateOperation, Result<int>>
    {
        private readonly IOperationRepository _operationRepository;
        private readonly IMapper _mapper;

        private IUnitOfWork _unitOfWork { get; set; }

        public CreateOperationHandler(IOperationRepository operationRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _operationRepository = operationRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateOperation request, CancellationToken cancellationToken)
        {
            var operation = _mapper.Map<Operation>(request);
            await _operationRepository.InsertAsync(operation);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(operation.Id);
        }
    }
}
