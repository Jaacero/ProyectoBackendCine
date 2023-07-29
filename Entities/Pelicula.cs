using System.ComponentModel.DataAnnotations.Schema;
using ProyectoBackendCine.Entities;
namespace IntroAEFCore.Entities;
public class Pelicula : BaseEntity
{
    [Column(TypeName = "varchar(100)")]
    public string Titulo { get; set; } = null!;
    public bool EnCines {get; set; }
    public DateTime FechaEstreno { get; set; }
     public ICollection<Comentario> Comentarios {get; set;}  = new List<Comentario>();
     public ICollection<Genero> Generos {get; set; } = new List<Genero>();
     public ICollection<PeliculaActor> PeliculasActores {get; set;} = new List<PeliculaActor>();




}