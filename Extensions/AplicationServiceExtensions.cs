using ProyectoBackendCine.Repositorios;
using ProyectoBackendCine.Interfaces;
using ProyectoBackendCine.UnityWork;

namespace ProyectoBackendCine.Extensions;

    public static class AplicationServiceExtensions
    {
        public static void AddAplicationServices(this IServiceCollection services){
            services.AddScoped<IUnityOfWork,UnityOfWork>();
        }
        
    }
