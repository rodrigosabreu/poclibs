using AutoMapper;

namespace _02___AutoMapper;
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<SourceModel, DestinationModel>()
            .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Idade, opt => opt.MapFrom(src => src.Age));
    }
}