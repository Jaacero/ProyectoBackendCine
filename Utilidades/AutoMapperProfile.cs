using AutoMapper;
using IntroAEFCore.Entities;
using IntroAEFCore.DTOS;
using ProyectoBackendCine.DTOS;

namespace IntroAEFCore.Utilidades
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<GeneroCreacionDTO,Genero>();
            CreateMap<ActorCreationDTO,Actor>();
            CreateMap<PeliculaCreationDTO,Pelicula>()
            .ForMember(ent => ent.Generos, dto => dto.MapFrom(campo => campo.Generos.Select(id => new Genero{Id=id})));
            CreateMap<PeliculaActorCtreationDTO,PeliculaActor>();
            CreateMap<ComentarioCreationDTO,Comentario>();
            CreateMap<ActorDTO,Actor>();
            CreateMap<Actor,ActorDTO>();
        }
    }

}