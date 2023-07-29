using System.Collections;
using ProyectoBackendCine.Entities;
namespace IntroAEFCore.Entities;
public class Genero : BaseEntity
{
 public string Nombre { get; set; } = null!;
 public ICollection<Pelicula> Peliculas { get; set;} = new List<Pelicula>();
}