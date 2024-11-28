using MediatR;
using ConsumerTrampos.Domain.Common;
using ConsumerTrampos.Domain.Consumers;

namespace ConsumerTrampos.Application.Consumers.Commands;

public record UpdateConsumerCommand : IRequest<Result<Unit>>
{
    public Guid Id { get; init; }
    public string CompanyName { get; init; }
    public CompanySize CompanySize { get; init; }
}