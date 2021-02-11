using FizzAPI.Service.Contract;
using System;

namespace FizzAPI.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}