using AutoMapper;
using REST_API.Data;
using REST_API.Models;

namespace REST_API.Profiles;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<CreateAddressDTO, Address>();
        CreateMap<UpdateAddressDTO, Address>();
        CreateMap<Address, ReadAddressDTO>();
    }
}