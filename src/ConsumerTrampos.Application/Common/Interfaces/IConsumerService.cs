using ConsumerTrampos.Application.Consumers;
using ConsumerTrampos.Application.Consumers.Commands;
using ConsumerTrampos.Application.Consumers.Queries;
using ConsumerTrampos.Domain.Common;
using MediatR;

namespace ConsumerTrampos.Application.Common.Interfaces;

public interface IConsumerService
{
    Task<Result<Guid>> CreateConsumerAsync(CreateConsumerCommand command);
    Task<Result<Unit>> UpdateConsumerAsync(UpdateConsumerCommand command);
    Task<Result<Unit>> DeleteConsumerAsync(Guid id);
    Task<ConsumerDto> GetConsumerAsync(Guid id);
    Task<List<ConsumerDto>> GetConsumersAsync();
}