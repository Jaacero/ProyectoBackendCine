using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using IntroAEFCore.Entities;
using ProyectoBackendCine.DTOS;

namespace ProyectoBackendCine.Interfaces
{
    public interface IActorInterface
    {
        Task<Actor> GetActorById(int id);
        Task<IEnumerable<Actor>> GetAllActores();
        Task<IEnumerable<Actor>> GetActoresByName(string nombre);
        Task<IEnumerable<ActorDTO>> GetByIdyName();
        Task<IEnumerable<ActorDTO>> GetActorAutoMapper();
        Task<IEnumerable<Actor>> Find(Expression<Func<Actor, bool>> expression);
        void Add(Actor actor);
        void AddRange(IEnumerable<Actor> actores);
        void Remove(Actor actor);
        void Update(Actor actor);
    }

   
}