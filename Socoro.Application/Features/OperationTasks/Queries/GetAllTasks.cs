using Socoro.Application.Extensions;
using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Socoro.Application.DTOs.Results;
using MediatR;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Socoro.Application.DTOs.Operation;

namespace Socoro.Application.Features.OperationTasks.Queries
{
    public class GetAllOperationTasks : IRequest<PaginatedResult<OperationTaskResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public GetAllOperationTasks(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }

    public class GetAllOperationTasksHandler : IRequestHandler<GetAllOperationTasks, PaginatedResult<OperationTaskResponse>>
    {
        private readonly IOperationTaskRepository _repository;

        public GetAllOperationTasksHandler(IOperationTaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<PaginatedResult<OperationTaskResponse>> Handle(GetAllOperationTasks request, CancellationToken cancellationToken)
        {
            Expression<Func<OperationTask, OperationTaskResponse>> expression = e => new OperationTaskResponse
            {
                Id = e.Id,
                Note = e.Note,
                DueDate = e.DueDate,
                Status = e.Status,
                OperationProcessId = e.OperationProcessId
                
            };
            var paginatedList = await _repository.OperationTasks
                .Select(expression)
                .ToPaginatedListAsync(request.PageNumber, request.PageSize);
            return paginatedList;
        }
    }
}