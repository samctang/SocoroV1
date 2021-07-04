using Socoro.Application.Interfaces.Shared;
using System;

namespace Socoro.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}