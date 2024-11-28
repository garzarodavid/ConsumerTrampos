using MediatR;

namespace ConsumerTrampos.Application.Consumers.Queries;

public record GetConsumerQuery : IRequest<ConsumerDto>
{
    public Guid Id { get; init; }
}