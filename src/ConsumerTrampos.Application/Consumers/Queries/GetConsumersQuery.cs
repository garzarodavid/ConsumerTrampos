using MediatR;
using ConsumerTrampos.Application.Consumers.Queries;

namespace ConsumerTrampos.Application.Consumers.Queries;

public record GetConsumersQuery : IRequest<List<ConsumerDto>>;