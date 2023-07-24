using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoBackendCine.Interfaces
{
    public interface IUnityOfWork
    {
        IActorInterface Actores {get;}
        Task<int> Save();
    }
}