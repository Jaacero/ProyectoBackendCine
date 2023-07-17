using System.Collections;

namespace IntroAEFCore.Entities;
public class Genero
{
 public int Id { get; set; }
 public string Nombre { get; set; } = null!;
 public ICollection<Pelicula> Peliculas { get; set;} = new List<Pelicula>();
}