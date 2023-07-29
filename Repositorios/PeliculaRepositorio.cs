
using System.Linq.Expressions;
using AutoMapper;
using IntroAEFCore.Controllers;
using IntroAEFCore.Entities;
using ProyectoBackendCine.DTOS;
using ProyectoBackendCine.Interfaces;

namespace ProyectoBackendCine.Repositorios
{
    public class PeliculaRepositorio : GenericRepository<Pelicula>, IPeliculaInterface
    {
        private readonly IMapper _mapper;

        public PeliculaRepositorio(AplicationDbContext context,IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }
   
        public  object GetById( int id)
        {
            var pelicula =  _context.Peliculas.Select(p =>
            new
            {
                Id = p.Id,
                Titulo = p.Titulo,
                FechaEstreno = p.FechaEstreno,
                Generos = p.Generos.Select(g => g.Nombre).ToList(),
                PeliculasActores = p.PeliculasActores
                .Select(pa =>new{ActorId = pa.ActorId,Personaje = pa.Personaje,NombreActor = pa.Actor.Nombre}).ToList(),
                Comentarios = p.Comentarios.Select(c =>new{Comentario = c.Contenido, Recomendar = c.Recomendar}).ToList()
    
            }).FirstOrDefault(p => p.Id == id);

            return pelicula;

        }
        //  public async Task<IEnumerable<Pelicula>> GetAllAsync(){

        //  }
        // public async IEnumerable<Pelicula> Find(Expression<Func<Pelicula, bool>> expression){

        // }
        // public async void Add(Pelicula entity){

        // }
        // public async void AddRange(IEnumerable<Pelicula> entities){

        // }
        // public async void Remove(Pelicula entity){

        // }
        // public async void RemoveRange(IEnumerable<Pelicula> entities){

        // }
        // public async void Update(Pelicula entity){

        // }
        
        
    }
}