using Socoro.Application.Interfaces.CacheRepositories;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Socoro.Application.Features.Customers.Queries.GetAllCached
{
    public class GetAllCustomersCachedQuery : IRequest<Result<List<GetAllCustomersCachedResponse>>>
    {
        public GetAllCustomersCachedQuery()
        {
        }
    }
    public class GetAllCustomersCachedQueryHandler : IRequestHandler<GetAllCustomersCachedQuery, Result<List<GetAllCustomersCachedResponse>>>
    {
        private readonly ICustomerCacheRepository _customerCache;
        private readonly IMapper _mapper;

        public GetAllCustomersCachedQueryHandler(ICustomerCacheRepository customerCache, IMapper mapper)
        {
            _customerCache = customerCache;
            _mapper = mapper;
        }

        public async Task<Result<List<GetAllCustomersCachedResponse>>> Handle(GetAllCustomersCachedQuery request, CancellationToken cancellationToken)
        {
            var customerList = await _customerCache.GetCachedListAsync();
            var mappedCustomers = _mapper.Map<List<GetAllCustomersCachedResponse>>(customerList);
            return Result<List<GetAllCustomersCachedResponse>>.Success(mappedCustomers);
        }
    }
}
