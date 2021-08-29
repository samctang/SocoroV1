using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;

namespace Socoro.Application.Features.OperationTypes.Queries
{
    public class GetOperationTypeById : IRequest<Result<OperationTypeResponse>>
    {
        public int Id { get; set; }
    }
    public class GetOperationTypeByIdHandler : IRequestHandler<GetOperationTypeById, Result<OperationTypeResponse>>
    {
        private readonly IOperationTypeRepository _operationTypeCache;
        private readonly IMapper _mapper;

        public GetOperationTypeByIdHandler(IOperationTypeRepository operationTypeCache, IMapper mapper)
        {
            _operationTypeCache = operationTypeCache;
            _mapper = mapper;
        }

        public async Task<Result<OperationTypeResponse>> Handle(GetOperationTypeById query, CancellationToken cancellationToken)
        {
            var operationType = await _operationTypeCache.GetByIdAsync(query.Id);
            var mappedOperationType = _mapper.Map<OperationTypeResponse>(operationType);
            return Result<OperationTypeResponse>.Success(mappedOperationType);
        }
    }
}