using AutoMapper;
using ConsumerTrampos.Application.Common.Interfaces;
using MediatR;

namespace ConsumerTrampos.Application.Consumers.Queries;

public class GetConsumerQueryHandler : IRequestHandler<GetConsumerQuery, ConsumerDto>
{
    private readonly IConsumerRepository _consumerRepository;
    private readonly IMapper _mapper;

    public GetConsumerQueryHandler(IConsumerRepository consumerRepository, IMapper mapper)
    {
        _consumerRepository = consumerRepository;
        _mapper = mapper;
    }

    public async Task<ConsumerDto> Handle(GetConsumerQuery request, CancellationToken cancellationToken)
    {
        var consumer = await _consumerRepository.GetConsumerByIdAsync(request.Id);

        // Aqui você pode adicionar lógica para lidar com o caso em que o Consumer não é encontrado,
        // por exemplo, retornando um erro ou lançando uma exceção.

        return _mapper.Map<ConsumerDto>(consumer);
    }
}