namespace Garbager.Services.GarbageScheduleMap.Domain.Exceptions;

/// <summary>
/// Exception type for domain exceptions
/// </summary>
public class GarbageScheduleMapDomainException : Exception
{
    public GarbageScheduleMapDomainException()
    { }

    public GarbageScheduleMapDomainException(string message)
        : base(message)
    { }

    public GarbageScheduleMapDomainException(string message, Exception innerException)
        : base(message, innerException)
    { }
}