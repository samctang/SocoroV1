using Socoro.Application.Extensions;
using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using AspNetCoreHero.Results;
using MediatR;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;

namespace Socoro.Application.Features.Operations.Queries
{
    public class GetAllOperations : IRequest<PaginatedResult<OperationResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllOperations(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }

    public class GetAllOperationsHandler : IRequestHandler<GetAllOperations, PaginatedResult<OperationResponse>>
    {
        private readonly IOperationRepository _repository;

        public GetAllOperationsHandler(IOperationRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaginatedResult<OperationResponse>> Handle(GetAllOperations request, CancellationToken cancellationToken)
        {
            Expression<Func<Operation, OperationResponse>> expression = e => new OperationResponse
            {
                Id = e.Id,
                TypeId = e.TypeId,
                CompanyId = (int)e.CompanyId,
                OperationNo = e.OperationNo,
                Agent = e.Agent,
                Shipper = e.Shipper,
                Consignee = e.Consignee,
                AgentRefNo = e.AgentRefNo,
                ShipperRefNo = e.ShipperRefNo,
                ConsigneeRefNo = e.ConsigneeRefNo,
                PoL = e.PoL,
                PoD = e.PoD,
                OriginAddr1 = e.OriginAddr1,
                OriginAddr2 = e.OriginAddr2,
                OriginCity = e.OriginCity,
                OriginState = e.OriginState,
                OriginZip = e.OriginZip,
                OriginCountry = e.OriginCountry,
                DestinationAddr1 = e.DestinationAddr1,
                DestinationAddr2 = e.DestinationAddr2,
                DestinationCity = e.DestinationCity,
                DestinationState = e.DestinationState,
                DestinationZip = e.DestinationZip,
                DestinationCountry = e.DestinationCountry,
                Progress = e.Progress,
                Status = e.Status,
                SubmittedDate = e.SubmittedDate,
                CompletedDate = e.CompletedDate
            };
            var paginatedList = await _repository.Operations
                .Select(expression)
                .ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return paginatedList;
        }
    }
}