using AutoMapper;
using ConsumerTrampos.Application.Consumers;
using ConsumerTrampos.Domain.Consumers;

namespace ConsumerTrampos.Application.Common.Mappings;

public class ConsumerProfile : Profile
{
    public ConsumerProfile()
    {
        CreateMap<Consumer, ConsumerDto>();
    }
}