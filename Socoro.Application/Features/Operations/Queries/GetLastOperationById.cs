using Socoro.Application.Interfaces.Repositories;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;

namespace Socoro.Application.Features.Operations.Queries
{
    public class GetLastOperationById : IRequest<Result<OperationResponse>>
    {
        public int Id { get; set; }
    }
    public class GetLastOperationByIdHandler : IRequestHandler<GetLastOperationById, Result<OperationResponse>>
    {
        private readonly IOperationRepository _operationRepository;
        private readonly IMapper _mapper;

        public GetLastOperationByIdHandler(IOperationRepository operationRepository, IMapper mapper)
        {
            _operationRepository = operationRepository;
            _mapper = mapper;
        }

        public async Task<Result<OperationResponse>> Handle(GetLastOperationById query, CancellationToken cancellationToken)
        {
            var operation = await _operationRepository.GetLastOperationByIdAsync(query.Id);
            var mappedOperation = _mapper.Map<OperationResponse>(operation);
            return Result<OperationResponse>.Success(mappedOperation);
        }
    }
}
