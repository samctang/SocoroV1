using Socoro.Application.Interfaces.Repositories;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Socoro.Application.Features.Customers.Queries.GetByCompanyId
{
    public class GetCustomersByCompanyIdQuery : IRequest<Result<List<GetCustomersByCompanyIdResponse>>>
    {
        public int CompanyId { get; set; }

        public class GetProductByIdQueryHandler : IRequestHandler<GetCustomersByCompanyIdQuery, Result<List<GetCustomersByCompanyIdResponse>>>
        {
            private readonly ICustomerRepository _customerRepository;
            private readonly IMapper _mapper;

            public GetProductByIdQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
            {
                _customerRepository = customerRepository;
                _mapper = mapper;
            }

            public async Task<Result<List<GetCustomersByCompanyIdResponse>>> Handle(GetCustomersByCompanyIdQuery query, CancellationToken cancellationToken)
            {
                var customerList = await _customerRepository.GetByCompanyIdAsync(query.CompanyId);
                var mappedCustomerList = _mapper.Map<List<GetCustomersByCompanyIdResponse>>(customerList);
                return Result<List<GetCustomersByCompanyIdResponse>>.Success(mappedCustomerList);
            }
        }
    }
}
