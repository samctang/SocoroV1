using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;
using System.Collections.Generic;

namespace Socoro.Application.Features.OperationProcessTypes.Queries
{
    public class GetOperationProcessTypeByOperationTypeId : IRequest<Result<List<OperationProcessTypeResponse>>>
    {
        public int OperationTypeId { get; set; }
    }
    public class GetOperationProcessTypeByOperationTypeIdHandler : IRequestHandler<GetOperationProcessTypeByOperationTypeId, Result<List<OperationProcessTypeResponse>>>
    {
        private readonly IOperationProcessTypeRepository _operationProcessTypeCache;
        private readonly IMapper _mapper;

        public GetOperationProcessTypeByOperationTypeIdHandler(IOperationProcessTypeRepository operationProcessTypeCache, IMapper mapper)
        {
            _operationProcessTypeCache = operationProcessTypeCache;
            _mapper = mapper;
        }

        public async Task<Result<List<OperationProcessTypeResponse>>> Handle(GetOperationProcessTypeByOperationTypeId query, CancellationToken cancellationToken)
        {
            var operationProcessTypeList = await _operationProcessTypeCache.GetByTypeIdAsync(query.OperationTypeId);
            var mappedOperationProcessType = _mapper.Map<List<OperationProcessTypeResponse>>(operationProcessTypeList);
            return Result<List<OperationProcessTypeResponse>>.Success(mappedOperationProcessType);
        }
    }
}