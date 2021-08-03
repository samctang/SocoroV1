using Socoro.Application.Features.OperationBookings.Commands;
using Socoro.Application.DTOs.Operation;
using AutoMapper;
using Socoro.Domain.Entities;

namespace Socoro.Application.Mappings
{
    internal class OperationBookingProfile : Profile
    {
        public OperationBookingProfile()
        {
            CreateMap<CreateOperationBooking, OperationBooking>().ReverseMap();
            CreateMap<OperationBookingResponse, OperationBooking>().ReverseMap();
        }
    }
}
