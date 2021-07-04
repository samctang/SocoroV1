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

namespace Socoro.Application.Features.Operations.Queries.GetAllPaged
{
    public class GetAllOperationsQuery : IRequest<PaginatedResult<GetAllOperationsResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllOperationsQuery(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }

    public class GGetAllOperationsQueryHandler : IRequestHandler<GetAllOperationsQuery, PaginatedResult<GetAllOperationsResponse>>
    {
        private readonly IOperationRepository _repository;

        public GGetAllOperationsQueryHandler(IOperationRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaginatedResult<GetAllOperationsResponse>> Handle(GetAllOperationsQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Operation, GetAllOperationsResponse>> expression = e => new GetAllOperationsResponse
            {
                Id = e.Id,
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
                SubmittedDate = e.SubmittedDate,
                CompletionDate = e.CompletionDate
            };
            var paginatedList = await _repository.Operations
                .Select(expression)
                .ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return paginatedList;
        }
    }
}