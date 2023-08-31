using Dominio.Entities;
using API.Dtos;
using AutoMapper;

namespace API.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Pais,PaisDto>().ReverseMap();
        CreateMap<Departamento,DepartamentoDto>().ReverseMap();
        CreateMap<Ciudad,CiudadDto>().ReverseMap();
    }
}