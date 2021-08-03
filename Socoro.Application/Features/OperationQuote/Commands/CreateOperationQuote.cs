using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Socoro.Application.Features.OperationQuotes.Commands
{
    public partial class CreateOperationQuote : IRequest<Result<int>>
    {
        public int Profit { get; set; }
        public int Documentation { get; set; }
        public int FF { get; set; }
        public int VGM { get; set; }
        public int Inland { get; set; }
        public int Others { get; set; }
        public string Explanation { get; set; }
        public int OperationId { get; set; }
    }

    public class CreateOperationQuoteHandler : IRequestHandler<CreateOperationQuote, Result<int>>
    {
        private readonly IOperationQuoteRepository _OperationQuoteRepository;
        private readonly IMapper _mapper;

        private IUnitOfWork _unitOfWork { get; set; }

        public CreateOperationQuoteHandler(IOperationQuoteRepository OperationQuoteRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _OperationQuoteRepository = OperationQuoteRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateOperationQuote request, CancellationToken cancellationToken)
        {
            var OperationQuote = _mapper.Map<OperationQuote>(request);
            await _OperationQuoteRepository.InsertAsync(OperationQuote);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(OperationQuote.Id);
        }
    }
}
