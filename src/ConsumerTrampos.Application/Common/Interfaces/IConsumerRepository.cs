using ConsumerTrampos.Domain.Consumers;

namespace ConsumerTrampos.Application.Common.Interfaces;

public interface IConsumerRepository
{
    Task<Consumer> GetConsumerByIdAsync(Guid id);
    Task<List<Consumer>> GetConsumersAsync();
    Task AddConsumerAsync(Consumer consumer);
    Task UpdateConsumerAsync(Consumer consumer);
    Task DeleteConsumerAsync(Guid id);
}