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
            (mT => new { mT.Id, mT.MovieTheaterName, mT.Address })));

        CreateMap<CreateManagerDTO, Manager>();
    }
}