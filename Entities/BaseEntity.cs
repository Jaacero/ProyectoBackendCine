
using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendCine.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id {get; set;}
        
    }
}