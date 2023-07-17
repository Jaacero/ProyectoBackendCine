using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroAEFCore.DTOS
{
    public class PeliculaActorCtreationDTO
    {
        public int ActorId {get; set;}
        public string Personaje {get; set;} = null!;
    }
}