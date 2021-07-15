using Socoro.Application.Interfaces.CacheRepositories;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;

namespace Socoro.Application.Features.Operations.Queries
{
    public class GetAllOperationsCached : IRequest<Result<List<OperationResponse>>>
    {
        public GetAllOperationsCached()
        {
        }
    }

    public class GetAllOperationsCachedHandler : IRequestHandler<GetAllOperationsCached, Result<List<OperationResponse>>>
    {
        private readonly IOperationCacheRepository _operationCache;
        private readonly IMapper _mapper;

        public GetAllOperationsCachedHandler(IOperationCacheRepository operationCache, IMapper mapper)
        {
            _operationCache = operationCache;
            _mapper = mapper;
        }

        public async Task<Result<List<OperationResponse>>> Handle(GetAllOperationsCached request, CancellationToken cancellationToken)
        {
            var operationList = await _operationCache.GetCachedListAsync();
            var mappedOperations = _mapper.Map<List<OperationResponse>>(operationList);
            return Result<List<OperationResponse>>.Success(mappedOperations);
        }
    }
}