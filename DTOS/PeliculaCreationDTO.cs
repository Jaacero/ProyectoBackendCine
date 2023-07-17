using IntroAEFCore.Entities;

namespace IntroAEFCore.DTOS
{
    public class PeliculaCreationDTO
    {
    public string Titulo { get; set; } = null!;
    public bool EnCines {get; set; }
    public DateTime FechaEstreno { get; set; }
      public List<int> Generos {get; set; } = new List<int>();
     public ICollection<PeliculaActorCtreationDTO> PeliculasActores {get; set;} 
     = new List<PeliculaActorCtreationDTO>();
    }
}