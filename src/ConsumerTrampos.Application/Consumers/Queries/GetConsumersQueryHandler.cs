using AutoMapper;
using ConsumerTrampos.Application.Common.Interfaces;
using MediatR;

namespace ConsumerTrampos.Application.Consumers.Queries;

public class GetConsumersQueryHandler : IRequestHandler<GetConsumersQuery, List<ConsumerDto>>
{
    private readonly IConsumerRepository _consumerRepository;
    private readonly IMapper _mapper;

    public GetConsumersQueryHandler(IConsumerRepository consumerRepository, IMapper mapper)
    {
        _consumerRepository = consumerRepository;
        _mapper = mapper;
    }

    public async Task<List<ConsumerDto>> Handle(GetConsumersQuery request, CancellationToken cancellationToken)
    {
        var consumers = await _consumerRepository.GetConsumersAsync();

        return _mapper.Map<List<ConsumerDto>>(consumers);
    }
}