using Socoro.Application.Features.OperationQuotes.Commands;
using Socoro.Application.DTOs.Operation;
using AutoMapper;
using Socoro.Domain.Entities;

namespace Socoro.Application.Mappings
{
    internal class OperationQuoteProfile : Profile
    {
        public OperationQuoteProfile()
        {
            CreateMap<CreateOperationQuote, OperationQuote>().ReverseMap();
            CreateMap<OperationQuoteResponse, OperationQuote>().ReverseMap();
        }
    }
}
