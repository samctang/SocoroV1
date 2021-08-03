using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;

namespace Socoro.Application.Features.Operations.Queries
{
    public class GetLastOperationByTypeId : IRequest<Result<OperationResponse>>
    {
        public int TypeId { get; set; }
    }
    public class GetLastOperationByTypeIdHandler : IRequestHandler<GetLastOperationByTypeId, Result<OperationResponse>>
    {
        private readonly IOperationRepository _operationRepository;
        private readonly IMapper _mapper;

        public GetLastOperationByTypeIdHandler(IOperationRepository operationRepository, IMapper mapper)
        {
            _operationRepository = operationRepository;
            _mapper = mapper;
        }

        public async Task<Result<OperationResponse>> Handle(GetLastOperationByTypeId query, CancellationToken cancellationToken)
        {
            var operation = await _operationRepository.GetLastOperationByTypeIdAsync(query.TypeId);
            var mappedOperation = _mapper.Map<OperationResponse>(operation);
            return Result<OperationResponse>.Success(mappedOperation);
        }
    }
}
