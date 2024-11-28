using ConsumerTrampos.Application.Common.Interfaces;
using ConsumerTrampos.Domain.Consumers;
using Microsoft.EntityFrameworkCore;

namespace ConsumerTrampos.Infrastructure.Persistence.Repositories;

public class ConsumerRepository : IConsumerRepository
{
    private readonly ApplicationDbContext _context;

    public ConsumerRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Consumer> GetConsumerByIdAsync(Guid id)
    {
        return await _context.Consumers.FindAsync(id);
    }

    public async Task<List<Consumer>> GetConsumersAsync()
    {
        return await _context.Consumers.ToListAsync();
    }

    public async Task AddConsumerAsync(Consumer consumer)
    {
        _context.Consumers.Add(consumer);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateConsumerAsync(Consumer consumer)
    {
        _context.Consumers.Update(consumer);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteConsumerAsync(Guid id)
    {
        var consumer = await _context.Consumers.FindAsync(id);
        if (consumer != null)
        {
            _context.Consumers.Remove(consumer);
            await _context.SaveChangesAsync();
        }
    }
}