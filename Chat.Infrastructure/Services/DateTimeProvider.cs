using Chat.Application.Common.Services;

namespace Chat.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.Now;
}