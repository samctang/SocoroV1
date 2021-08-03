using Socoro.Application.Interfaces.Repositories;
using Socoro.Domain.Entities;
using Socoro.Application.DTOs.Results;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Socoro.Application.Features.OperationBookings.Commands
{
    public partial class CreateOperationBooking : IRequest<Result<int>>
    {
        public string BookingNumber { get; set; }
        public string Vessel { get; set; }
        public int Voyage { get; set; }
        public DateTime DocumentDate { get; set; }
        public TimeSpan DocumentTime { get; set; }
        public DateTime CargoDate { get; set; }
        public TimeSpan CargoTime { get; set; }
        public DateTime VGMDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public bool Ramp { get; set; }
        public DateTime RampDate { get; set; }
        public int OperationCargoId { get; set; }
    }

    public class CreateOperationBookingHandler : IRequestHandler<CreateOperationBooking, Result<int>>
    {
        private readonly IOperationBookingRepository _OperationBookingRepository;
        private readonly IMapper _mapper;

        private IUnitOfWork _unitOfWork { get; set; }

        public CreateOperationBookingHandler(IOperationBookingRepository OperationBookingRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _OperationBookingRepository = OperationBookingRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<int>> Handle(CreateOperationBooking request, CancellationToken cancellationToken)
        {
            var OperationBooking = _mapper.Map<OperationBooking>(request);
            await _OperationBookingRepository.InsertAsync(OperationBooking);
            await _unitOfWork.Commit(cancellationToken);
            return Result<int>.Success(OperationBooking.Id);
        }
    }
}
