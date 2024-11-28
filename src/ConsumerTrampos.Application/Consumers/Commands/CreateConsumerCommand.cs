using ConsumerTrampos.Domain.Consumers;
using ConsumerTrampos.Domain.Common;
using MediatR;

namespace ConsumerTrampos.Application.Consumers.Commands;

public record CreateConsumerCommand : IRequest<Result<Guid>>
{
    public string CompanyName { get; init; }
    public CompanySize CompanySize { get; init; }
}