using ConsumerTrampos.Application.Common.Interfaces;
using ConsumerTrampos.Domain.Common;

using MediatR;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsumerTrampos.Application.Consumers.Commands;

public class UpdateConsumerCommandHandler : IRequestHandler<UpdateConsumerCommand, Result<Unit>>
{
    private readonly IConsumerRepository _consumerRepository;

    public UpdateConsumerCommandHandler(IConsumerRepository consumerRepository)
    {
        _consumerRepository = consumerRepository;
    }

    public async Task<Result<Unit>> Handle(UpdateConsumerCommand request, CancellationToken cancellationToken)
    {
        var consumer = await _consumerRepository.GetConsumerByIdAsync(request.Id);

        if (consumer == null)
        {
            return Result<Unit>.Failure(new Domain.Common.Error("Consumer.NotFound", "Consumer not found."));
        }

        consumer.Update(request.CompanyName, request.CompanySize);

        await _consumerRepository.UpdateConsumerAsync(consumer);

        return Result<Unit>.Success(Unit.Value);
    }
}