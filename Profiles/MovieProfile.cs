using AutoMapper;
using REST_API.Models;
using REST_API.Data.DTOs;

namespace REST_API;

public class MovieProfile : Profile 
{
    public MovieProfile()
    {
        CreateMap<CreateMovieDTO, Movie>();
        CreateMap<Movie, ReadMovieDTO>();
        CreateMap<CreateMovieDTO, Movie>();
    }     
}