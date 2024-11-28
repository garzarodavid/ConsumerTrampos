using ConsumerTrampos.Application.Common.Interfaces;
using ConsumerTrampos.Domain.Common;
using MediatR;

namespace ConsumerTrampos.Application.Consumers.Commands
{
    public class DeleteConsumerCommandHandler : IRequestHandler<DeleteConsumerCommand, Result<Unit>>
    {
        private readonly IConsumerRepository _consumerRepository;

        public DeleteConsumerCommandHandler(IConsumerRepository consumerRepository)
        {
            _consumerRepository = consumerRepository;
        }

        public async Task<Result<Unit>> Handle(DeleteConsumerCommand request, CancellationToken cancellationToken)
        {
            await _consumerRepository.DeleteConsumerAsync(request.Id);

            return Result<Unit>.Success(Unit.Value);
        }
    }
}