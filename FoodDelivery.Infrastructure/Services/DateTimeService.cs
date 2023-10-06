using FoodDelivery.Application.Interfaces;

namespace FoodDelivery.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}