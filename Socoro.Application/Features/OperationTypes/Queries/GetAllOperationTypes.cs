using Socoro.Application.Interfaces.Repositories;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;
namespace Socoro.Application.Features.OperationTypes.Queries
{
    public class GetAllOperationTypes : IRequest<Result<List<OperationTypeResponse>>>
    {
        public GetAllOperationTypes() { }
    }
    public class GetAllOperationTypesHandler : IRequestHandler<GetAllOperationTypes, Result<List<OperationTypeResponse>>>
    {
        private readonly IOperationTypeRepository _operationType;
        private readonly IMapper _mapper;

        public GetAllOperationTypesHandler(IOperationTypeRepository operationTypeCache, IMapper mapper)
        {
            _operationType = operationTypeCache;
            _mapper = mapper;
        }

        public async Task<Result<List<OperationTypeResponse>>> Handle(GetAllOperationTypes request, CancellationToken cancellationToken)
        {
            var operationTypeList = await _operationType.GetListAsync();
            var mappedOperationTypes = _mapper.Map<List<OperationTypeResponse>>(operationTypeList);
            return Result<List<OperationTypeResponse>>.Success(mappedOperationTypes);
        }
    }
}
