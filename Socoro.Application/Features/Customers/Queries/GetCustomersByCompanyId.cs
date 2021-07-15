using Socoro.Application.Interfaces.Repositories;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Customer;
using Socoro.Domain.Entities;

namespace Socoro.Application.Features.Customers.Queries
{
    public class GetCustomersByCompanyId : IRequest<Result<List<CustomerResponse>>>
    {
        public int Id { get; set; }
    }
    public class GetCustomersByCompanyIdHandler : IRequestHandler<GetCustomersByCompanyId, Result<List<CustomerResponse>>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomersByCompanyIdHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<Result<List<CustomerResponse>>> Handle(GetCustomersByCompanyId query, CancellationToken cancellationToken)
        {
            var customerList = await _customerRepository.GetByCompanyIdAsync(query.Id);
            var mappedCustomerList = _mapper.Map<List<CustomerResponse>>(customerList);
            return Result<List<CustomerResponse>>.Success(mappedCustomerList);
        }
    }
}
