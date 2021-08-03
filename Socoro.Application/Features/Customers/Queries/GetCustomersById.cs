using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Customer;

namespace Socoro.Application.Features.Customers.Queries
{
    public class GetCustomersById : IRequest<Result<CustomerResponse>>
    {
        public int Id { get; set; }
    }
    public class GetCustomersByIdHandler : IRequestHandler<GetCustomersById, Result<CustomerResponse>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomersByIdHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<Result<CustomerResponse>> Handle(GetCustomersById query, CancellationToken cancellationToken)
        {
            var customerList = await _customerRepository.GetByIdAsync(query.Id);
            var mappedCustomerList = _mapper.Map<CustomerResponse>(customerList);
            return Result<CustomerResponse>.Success(mappedCustomerList);
        }
    }
}
