
using IntroAEFCore.Entities;
using ProyectoBackendCine.DTOS;

namespace ProyectoBackendCine.Interfaces
{
    public interface IActorInterface : IGenericRepository<Actor>
    {
   
        Task<IEnumerable<Actor>> GetActoresByName(string nombre);
        Task<IEnumerable<ActorDTO>> GetByIdyName();
        Task<IEnumerable<ActorDTO>> GetActorAutoMapper();
        Actor GetActorById(int id);
        void Remove(Task<Actor> actor);
    }

   
}