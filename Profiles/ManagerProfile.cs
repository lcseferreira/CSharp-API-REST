using AutoMapper;
using REST_API.Data;
using REST_API.Models;

namespace REST_API.Profiles;

public class ManagerProfile : Profile
{
    public ManagerProfile()
    {
        CreateMap<Manager, ReadManagerDTO>();
        CreateMap<CreateManagerDTO, Manager>();
    }
}