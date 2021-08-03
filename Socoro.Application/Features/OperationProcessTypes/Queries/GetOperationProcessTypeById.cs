using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;

namespace Socoro.Application.Features.OperationProcessTypes.Queries
{
    public class GetOperationProcessTypeById : IRequest<Result<OperationProcessTypeResponse>>
    {
        public int Id { get; set; }
    }
    public class GetOperationProcessTypeByIdHandler : IRequestHandler<GetOperationProcessTypeById, Result<OperationProcessTypeResponse>>
    {
        private readonly IOperationProcessTypeRepository _operationProcessType;
        private readonly IMapper _mapper;

        public GetOperationProcessTypeByIdHandler(IOperationProcessTypeRepository operationProcessType, IMapper mapper)
        {
            _operationProcessType = operationProcessType;
            _mapper = mapper;
        }

        public async Task<Result<OperationProcessTypeResponse>> Handle(GetOperationProcessTypeById query, CancellationToken cancellationToken)
        {
            var operationProcessType = await _operationProcessType.GetByIdAsync(query.Id);
            var mappedOperationProcessType = _mapper.Map<OperationProcessTypeResponse>(operationProcessType);
            return Result<OperationProcessTypeResponse>.Success(mappedOperationProcessType);
        }
    }
}