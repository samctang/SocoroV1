using Socoro.Application.Interfaces.Repositories;
using AspNetCoreHero.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;
using Socoro.Domain.Entities;

namespace Socoro.Application.Features.Operations.Commands
{
    public class UpdateOperation : IRequest<Result<int>>
    {
        public int Id { get; set; }
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
        public int Progress { get; set; }
        public string Status { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int CompanyId { get; set; }
    }
    public class UpdateOperationHandler : IRequestHandler<UpdateOperation, Result<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOperationRepository _operationRepository;

        public UpdateOperationHandler(IOperationRepository operationRepository, IUnitOfWork unitOfWork)
        {
            _operationRepository = operationRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<int>> Handle(UpdateOperation command, CancellationToken cancellationToken)
        {
            var operation = await _operationRepository.GetByIdAsync(command.Id);

            if (operation == null)
            {
                return Result<int>.Fail($"Operation Not Found.");
            }
            else
            {
                operation.OperationNo = command.OperationNo ?? operation.OperationNo;
                operation.TypeId = (command.TypeId == 0) ? operation.TypeId : command.TypeId;
                operation.Agent = command.Agent ?? operation.Agent;
                operation.Shipper = command.Shipper ?? operation.Shipper;
                operation.Consignee = command.Consignee ?? operation.Consignee;
                operation.AgentRefNo = command.AgentRefNo ?? operation.AgentRefNo;
                operation.ShipperRefNo = command.ShipperRefNo ?? operation.ShipperRefNo;
                operation.ConsigneeRefNo = command.ConsigneeRefNo ?? operation.ConsigneeRefNo;
                operation.PoL = command.PoL ?? operation.PoL;
                operation.PoD = command.PoD ?? operation.PoD;
                operation.OriginAddr1 = command.OriginAddr1 ?? operation.OriginAddr1;
                operation.OriginAddr2 = command.OriginAddr2 ?? operation.OriginAddr2;
                operation.OriginCity = command.OriginCity ?? operation.OriginCity;
                operation.OriginState = command.OriginState ?? operation.OriginState;
                operation.OriginZip = command.OriginZip ?? operation.OriginZip;
                operation.OriginCountry = command.OriginCountry ?? operation.OriginCountry;
                operation.DestinationAddr1 = command.DestinationAddr1 ?? operation.DestinationAddr1;
                operation.DestinationAddr2 = command.DestinationAddr2 ?? operation.DestinationAddr2;
                operation.DestinationCity = command.DestinationCity ?? operation.DestinationCity;
                operation.DestinationState = command.DestinationState ?? operation.DestinationState;
                operation.DestinationZip = command.DestinationZip ?? operation.DestinationZip;
                operation.DestinationCountry = command.DestinationCountry ?? operation.DestinationCountry;
                operation.Progress = (command.Progress == 0) ? operation.Progress : command.Progress;
                operation.Status = command.Status ?? operation.Status;
                operation.SubmittedDate = command.SubmittedDate ?? operation.SubmittedDate;
                operation.CompletedDate = command.CompletedDate ?? operation.CompletedDate;
                operation.CompanyId = (command.CompanyId == 0) ? operation.CompanyId : command.CompanyId;

                await _operationRepository.UpdateAsync(operation);
                await _unitOfWork.Commit(cancellationToken);
                return Result<int>.Success(operation.Id);
            }
        }
    }
}