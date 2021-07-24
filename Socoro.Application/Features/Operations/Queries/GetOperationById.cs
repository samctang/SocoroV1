﻿using Socoro.Application.Interfaces.CacheRepositories;
using AspNetCoreHero.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;

namespace Socoro.Application.Features.Operations.Queries
{
    public class GetOperationById : IRequest<Result<OperationResponse>>
    {
        public int Id { get; set; }
    }
    public class GetOperationByIdHandler : IRequestHandler<GetOperationById, Result<OperationResponse>>
    {
        private readonly IOperationCacheRepository _operationCache;
        private readonly IMapper _mapper;

        public GetOperationByIdHandler(IOperationCacheRepository operationCache, IMapper mapper)
        {
            _operationCache = operationCache;
            _mapper = mapper;
        }

        public async Task<Result<OperationResponse>> Handle(GetOperationById query, CancellationToken cancellationToken)
        {
            var operation = await _operationCache.GetByIdAsync(query.Id);
            var mappedOperation = _mapper.Map<OperationResponse>(operation);
            return Result<OperationResponse>.Success(mappedOperation);
        }
    }
}