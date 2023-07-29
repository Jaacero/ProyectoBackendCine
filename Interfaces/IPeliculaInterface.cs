using IntroAEFCore.Entities;
using ProyectoBackendCine.DTOS;
namespace ProyectoBackendCine.Interfaces
{
    public interface IPeliculaInterface :IGenericRepository<Pelicula>
    {
        object GetById( int id);
    }
}