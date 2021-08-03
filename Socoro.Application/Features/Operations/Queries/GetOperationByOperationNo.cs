using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;

namespace Socoro.Application.Features.Operations.Queries
{
    public class GetOperationByOperationNo : IRequest<Result<OperationResponse>>
    {
        public string OperationNo { get; set; }
    }
    public class GetOperationByOperationNoHandler : IRequestHandler<GetOperationByOperationNo, Result<OperationResponse>>
    {
        private readonly IOperationRepository _operation;
        private readonly IMapper _mapper;

        public GetOperationByOperationNoHandler(IOperationRepository operation, IMapper mapper)
        {
            _operation = operation;
            _mapper = mapper;
        }

        public async Task<Result<OperationResponse>> Handle(GetOperationByOperationNo query, CancellationToken cancellationToken)
        {
            var operation = await _operation.GetByOperationNoAsync(query.OperationNo);
            var mappedOperation = _mapper.Map<OperationResponse>(operation);
            return Result<OperationResponse>.Success(mappedOperation);
        }
    }
}