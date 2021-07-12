﻿using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Socoro.Application.Features.Customers.Commands.Create
{
    public partial class CreateCustomerCommand : IRequest<Result<int>>
    {
        public int CompanyId { get; set; }
        public int TypeId { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string ContactPhone { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string PhyAddr1 { get; set; }
        public string PhyAddr2 { get; set; }
        public string PhyCity { get; set; }
        public string PhyState { get; set; }
        public string PhyZip { get; set; }
        public string DocumentalEmail { get; set; }
    }
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Result<int>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        private IUnitOfWork _unitOfWork { get; set; }

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Customer>(request);
            await _customerRepository.InsertAsync(customer);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(customer.Id);
        }
    }
}
