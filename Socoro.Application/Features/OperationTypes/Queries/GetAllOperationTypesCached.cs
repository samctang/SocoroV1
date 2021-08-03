using Socoro.Application.Interfaces.CacheRepositories;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;
namespace Socoro.Application.Features.OperationTypes.Queries
{
    public class GetAllOperationTypesCached : IRequest<Result<List<OperationTypeResponse>>>
    {
        public GetAllOperationTypesCached() { }
    }
    public class GetAllOperationTypesCachedHandler : IRequestHandler<GetAllOperationTypesCached, Result<List<OperationTypeResponse>>>
    {
        private readonly IOperationTypeCacheRepository _operationTypeCache;
        private readonly IMapper _mapper;

        public GetAllOperationTypesCachedHandler(IOperationTypeCacheRepository operationTypeCache, IMapper mapper)
        {
            _operationTypeCache = operationTypeCache;
            _mapper = mapper;
        }

        public async Task<Result<List<OperationTypeResponse>>> Handle(GetAllOperationTypesCached request, CancellationToken cancellationToken)
        {
            var operationTypeList = await _operationTypeCache.GetCachedListAsync();
            var mappedOperationTypes = _mapper.Map<List<OperationTypeResponse>>(operationTypeList);
            return Result<List<OperationTypeResponse>>.Success(mappedOperationTypes);
        }
    }
}
