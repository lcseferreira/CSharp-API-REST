using AutoMapper;
using REST_API.Data.DTOs;
using REST_API.Models;

namespace REST_API.Profiles;

public class MovieTheaterProfile : Profile
{
    public MovieTheaterProfile()
    {
        CreateMap<UpdateMovieTheaterDTO, MovieTheater>();
        CreateMap<CreateMovieTheaterDTO, MovieTheater>();
        CreateMap<MovieTheater, ReadMovieTheaterDTO>();
    }
}
