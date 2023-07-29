
using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using IntroAEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using ProyectoBackendCine.DTOS;
using ProyectoBackendCine.Interfaces;

namespace ProyectoBackendCine.Repositorios;

public class ActorRepositorio :GenericRepository<Actor> , IActorInterface
{
    private readonly AplicationDbContext context;
    private readonly IMapper mapper;

    public ActorRepositorio(AplicationDbContext context, IMapper mapper):base(context)
    {
        this.context = context;   
        this.mapper = mapper;
    }
    public override void Add(Actor actor)
    {
        context.Actores.Add(actor);
    }

    public override void AddRange(IEnumerable<Actor> actores)
    {
        context.Actores.AddRange(actores);
    }

    public override Task<IEnumerable<Actor>> Find(Expression<Func<Actor, bool>> expression)
    {
        var actores = context.Set<Actor>().Where(expression);
        return (Task<IEnumerable<Actor>>)actores;
    }

    public override async Task<Actor> GetByIdAsync(int id)
    {
        return await context.Actores.FindAsync(id);

    }

    public override async Task<IEnumerable<Actor>> GetAllAsync()
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
    public override void Remove(Actor actor)
    {
        context.Remove(actor);
    }

    public override void Update(Actor actor)
    {
        context.Actores.Update(actor);
    }

    public override void RemoveRange(IEnumerable<Actor> actores)
    {
        throw new NotImplementedException();
    }

    public Actor GetActorById(int id)
    {
       return context.Actores.FirstOrDefault(x =>x.Id == id);
    }

    public void Remove(Task<Actor> actor)
    {
        throw new NotImplementedException();
    }
}
