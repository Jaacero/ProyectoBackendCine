using System.ComponentModel.DataAnnotations.Schema;
using ProyectoBackendCine.Entities;

namespace IntroAEFCore.Entities;
public class Actor :BaseEntity
{
   
    [Column(TypeName = "varchar(80)")]
    public string Nombre { get; set; } = null!;
    public DateTime FechaNacimineto { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Fortuna { get; set; }
    public ICollection<PeliculaActor> PeliculasActores { get; set; } =new List<PeliculaActor>();
}