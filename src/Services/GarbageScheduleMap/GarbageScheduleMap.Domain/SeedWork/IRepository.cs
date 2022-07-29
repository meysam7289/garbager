namespace Garbager.Services.GarbageScheduleMap.Domain.SeedWork;

public interface IRepository<T> where T : IAggregateRoot
{
    IUnitOfWork UnitOfWork { get; }
}