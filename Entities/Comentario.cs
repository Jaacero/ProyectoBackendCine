using System.Collections.Generic;
using ProyectoBackendCine.Entities;
namespace IntroAEFCore.Entities;

    public class Comentario : BaseEntity
    {
        public string ? Contenido {get; set;}
        public bool Recomendar {get; set;}
        public int PeliculaId {get; set;}
        public Pelicula Pelicula {get; set;} = null!;
       

    }
