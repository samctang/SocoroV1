using Socoro.Application.Interfaces.CacheRepositories;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Socoro.Application.Features.Operations.Queries.GetById
{
    public class GetOperationByIdQuery : IRequest<Result<GetOperationByIdResponse>>
    {
        public int Id { get; set; }

        public class GetOperationByIdQueryHandler : IRequestHandler<GetOperationByIdQuery, Result<GetOperationByIdResponse>>
        {
            private readonly IOperationCacheRepository _operationCache;
            private readonly IMapper _mapper;

            public GetOperationByIdQueryHandler(IOperationCacheRepository operationCache, IMapper mapper)
            {
                _operationCache = operationCache;
                _mapper = mapper;
            }

            public async Task<Result<GetOperationByIdResponse>> Handle(GetOperationByIdQuery query, CancellationToken cancellationToken)
            {
                var operation = await _operationCache.GetByIdAsync(query.Id);
                var mappedOperation = _mapper.Map<GetOperationByIdResponse>(operation);
                return Result<GetOperationByIdResponse>.Success(mappedOperation);
            }
        }
    }
}