using ConsumerTrampos.Application.Common.Interfaces;
using ConsumerTrampos.Application.Consumers.Commands;
using ConsumerTrampos.Application.Consumers.Queries;
using ConsumerTrampos.Domain.Common;
using MediatR;

namespace ConsumerTrampos.Application.Consumers;

public class ConsumerService : IConsumerService
{
    private readonly IMediator _mediator;

    public ConsumerService(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<Result<Guid>> CreateConsumerAsync(CreateConsumerCommand command)
    {
        return await _mediator.Send(command);
    }

    public async Task<Result<Unit>> UpdateConsumerAsync(UpdateConsumerCommand command)
    {
        return await _mediator.Send(command);
    }

    public async Task<Result<Unit>> DeleteConsumerAsync(Guid id)
    {
        return await _mediator.Send(new DeleteConsumerCommand { Id = id });
    }

    public async Task<List<ConsumerDto>> GetConsumersAsync()
    {
        return await _mediator.Send(new GetConsumersQuery());
    }

    public async Task<ConsumerDto> GetConsumerAsync(Guid id)
    {
        return await _mediator.Send(new GetConsumerQuery { Id = id });  
    }
}