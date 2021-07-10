using Socoro.Application.Interfaces.CacheRepositories;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Socoro.Application.Features.OperationTypes.Queries.GetAllOperationTypes
{
    public class GetAllOperationTypesCachedQuery : IRequest<Result<List<GetAllOperationTypesCachedResponse>>>
    {
        public GetAllOperationTypesCachedQuery()
        {
        }
    }

    public class GetAllOperationTypesCachedQueryHandler : IRequestHandler<GetAllOperationTypesCachedQuery, Result<List<GetAllOperationTypesCachedResponse>>>
    {
        private readonly IOperationTypeCacheRepository _operationTypeCache;
        private readonly IMapper _mapper;

        public GetAllOperationTypesCachedQueryHandler(IOperationTypeCacheRepository operationTypeCache, IMapper mapper)
        {
            _operationTypeCache = operationTypeCache;
            _mapper = mapper;
        }

        public async Task<Result<List<GetAllOperationTypesCachedResponse>>> Handle(GetAllOperationTypesCachedQuery request, CancellationToken cancellationToken)
        {
            var operationTypeList = await _operationTypeCache.GetCachedListAsync();
            var mappedOperationTypes = _mapper.Map<List<GetAllOperationTypesCachedResponse>>(operationTypeList);
            return Result<List<GetAllOperationTypesCachedResponse>>.Success(mappedOperationTypes);
        }
    }
}
