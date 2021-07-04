using Socoro.Application.Interfaces.CacheRepositories;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Socoro.Application.Features.Operations.Queries.GetAllCached
{
    public class GetAllOperationsCachedQuery : IRequest<Result<List<GetAllOperationsCachedResponse>>>
    {
        public GetAllOperationsCachedQuery()
        {
        }
    }

    public class GetAllOperationsCachedQueryHandler : IRequestHandler<GetAllOperationsCachedQuery, Result<List<GetAllOperationsCachedResponse>>>
    {
        private readonly IOperationCacheRepository _operationCache;
        private readonly IMapper _mapper;

        public GetAllOperationsCachedQueryHandler(IOperationCacheRepository operationCache, IMapper mapper)
        {
            _operationCache = operationCache;
            _mapper = mapper;
        }

        public async Task<Result<List<GetAllOperationsCachedResponse>>> Handle(GetAllOperationsCachedQuery request, CancellationToken cancellationToken)
        {
            var operationList = await _operationCache.GetCachedListAsync();
            var mappedOperations = _mapper.Map<List<GetAllOperationsCachedResponse>>(operationList);
            return Result<List<GetAllOperationsCachedResponse>>.Success(mappedOperations);
        }
    }
}