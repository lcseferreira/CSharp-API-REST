using AutoMapper;
using REST_API.Data;
using REST_API.Models;

namespace REST_API.Profiles;

public class ManagerProfile : Profile
{
    public ManagerProfile()
    {
        CreateMap<Manager, ReadManagerDTO>()
            .ForMember(manager => manager.MovieTheaters, opts => opts
            .MapFrom(manager => manager.MovieTheaters.Select
            (mT => new { mT.MovieTheaterName, mT.Address.Street, mT.Address.District, mT.Address.Number })));

        CreateMap<CreateManagerDTO, Manager>();
    }
}