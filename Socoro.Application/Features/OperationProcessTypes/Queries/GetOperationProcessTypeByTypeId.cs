using Socoro.Application.Interfaces.CacheRepositories;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;
using System.Collections.Generic;

namespace Socoro.Application.Features.OperationProcessTypes.Queries
{
    public class GetOperationProcessTypeByTypeId : IRequest<Result<List<OperationProcessTypeResponse>>>
    {
        public int TypeId { get; set; }
    }
    public class GetOperationProcessTypeByTypeIdHandler : IRequestHandler<GetOperationProcessTypeByTypeId, Result<List<OperationProcessTypeResponse>>>
    {
        private readonly IOperationProcessTypeCacheRepository _operationProcessTypeCache;
        private readonly IMapper _mapper;

        public GetOperationProcessTypeByTypeIdHandler(IOperationProcessTypeCacheRepository operationProcessTypeCache, IMapper mapper)
        {
            _operationProcessTypeCache = operationProcessTypeCache;
            _mapper = mapper;
        }

        public async Task<Result<List<OperationProcessTypeResponse>>> Handle(GetOperationProcessTypeByTypeId query, CancellationToken cancellationToken)
        {
            var operationProcessTypeList = await _operationProcessTypeCache.GetByTypeIdAsync(query.TypeId);
            var mappedOperationProcessType = _mapper.Map<List<OperationProcessTypeResponse>>(operationProcessTypeList);
            return Result<List<OperationProcessTypeResponse>>.Success(mappedOperationProcessType);
        }
    }
}