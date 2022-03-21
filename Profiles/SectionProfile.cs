using AutoMapper;
using REST_API.Data;
using REST_API.Models;

namespace REST_API.Profiles;

public class SectionProfile : Profile
{
    public SectionProfile()
    {

        CreateMap<CreateSectionDTO, Section>();
        CreateMap<Section, ReadSectionDTO>()
            .ForMember(dto => dto.StartSection, opts => opts
            .MapFrom(dto => dto.EndSection.AddMinutes(dto.Movie.MovieLengthInMinutes * (-1))));

    }
}