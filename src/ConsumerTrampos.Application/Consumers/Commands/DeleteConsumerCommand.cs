using MediatR;
using ConsumerTrampos.Domain.Common;

namespace ConsumerTrampos.Application.Consumers.Commands;

public record DeleteConsumerCommand : IRequest<Result<Unit>>
{
    public Guid Id { get; init; }
}