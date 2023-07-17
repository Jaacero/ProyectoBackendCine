using System.ComponentModel.DataAnnotations;
namespace IntroAEFCore.DTOS;

    public class ActorCreationDTO
    {
        public string Nombre { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public int Fortuna { get; set; }
        
    }
