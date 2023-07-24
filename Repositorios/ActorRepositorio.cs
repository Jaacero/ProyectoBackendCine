
using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using IntroAEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using ProyectoBackendCine.DTOS;
using ProyectoBackendCine.Interfaces;

namespace ProyectoBackendCine.Repositorios;

public class ActorRepositorio : IActorInterface
{
    private readonly AplicationDbContext context;
    private readonly IMapper mapper;

    public ActorRepositorio(AplicationDbContext context, IMapper mapper)
    {
        this.context = context;   
        this.mapper = mapper;
    }
    public void Add(Actor actor)
    {
        context.Actores.Add(actor);
    }

    public void AddRange(IEnumerable<Actor> actores)
    {
        context.Actores.AddRange(actores);
    }

    public Task<IEnumerable<Actor>> Find(Expression<Func<Actor, bool>> expression)
    {
        var actores = context.Set<Actor>().Where(expression);
        return (Task<IEnumerable<Actor>>)actores;
    }

    public async Task<Actor> GetActorById(int id)
    {
        return await context.Actores.FindAsync(id);

    }

    public async Task<IEnumerable<Actor>> GetAllActores()
    {
        return await context.Actores
        .Include(x => x.PeliculasActores)
        .OrderBy(x => x.Nombre)
            .ThenBy(x => x.FechaNacimineto)
        .ToListAsync();
    }
    public async Task<IEnumerable<Actor>> GetActoresByName(string nombre)
    {
        return await context.Actores.Where(x => x.Nombre.Contains(nombre))
        .OrderBy(x => x.Nombre)
            .ThenBy(x => x.FechaNacimineto)
        .ToListAsync();
    }
    public async Task<IEnumerable<ActorDTO>> GetByIdyName()
    {
        var actores = await context.Actores
        .Select(a => new ActorDTO{Id = a.Id ,Nombre = a.Nombre})
        .ToListAsync();
        return actores;
    }
    public async Task<IEnumerable<ActorDTO>> GetActorAutoMapper()
    {
        return await context.Actores.ProjectTo<ActorDTO>(mapper.ConfigurationProvider)
        .ToListAsync();
    }
    public void Remove(Actor actor)
    {
        context.Actores.Remove(actor);
    }

    public void Update(Actor actor)
    {
        context.Actores.Update(actor);
    }
}
