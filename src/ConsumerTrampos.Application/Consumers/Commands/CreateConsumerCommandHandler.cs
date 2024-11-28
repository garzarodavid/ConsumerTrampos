using ConsumerTrampos.Application.Common.Interfaces;
using ConsumerTrampos.Domain.Consumers;
using ConsumerTrampos.Domain.Common;
using MediatR;

namespace ConsumerTrampos.Application.Consumers.Commands;

public class CreateConsumerCommandHandler : IRequestHandler<CreateConsumerCommand, Result<Guid>>
{
    private readonly IConsumerRepository _consumerRepository;

    public CreateConsumerCommandHandler(IConsumerRepository consumerRepository)
    {
        _consumerRepository = consumerRepository;
    }

    public async Task<Result<Guid>> Handle(CreateConsumerCommand request, CancellationToken cancellationToken)
    {
        var consumer = new Consumer(request.CompanyName, request.CompanySize);

        await _consumerRepository.AddConsumerAsync(consumer);

        return Result<Guid>.Success(consumer.Id);
    }
}