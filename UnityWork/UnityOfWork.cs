using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProyectoBackendCine.Interfaces;
using ProyectoBackendCine.Repositorios;

namespace ProyectoBackendCine.UnityWork;

public class UnityOfWork : IUnityOfWork, IDisposable
{
    private readonly AplicationDbContext context;
    private readonly IMapper mapper;
    private ActorRepositorio _actores;

    public UnityOfWork(AplicationDbContext context,IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    public IActorInterface Actores
    {
        get
        {
            _actores ??= new ActorRepositorio(context,mapper);
            return _actores;
        }
    }

    public void Dispose()
    {
        context.Dispose();
    }

    public Task<int> Save()
    {
       return  context.SaveChangesAsync();
    }
}
