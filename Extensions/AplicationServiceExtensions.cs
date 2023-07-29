using ProyectoBackendCine.Repositorios;
using ProyectoBackendCine.Interfaces;
using ProyectoBackendCine.UnityWork;

namespace ProyectoBackendCine.Extensions;

    public static class AplicationServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>{
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        }
        public static void AddAplicationServices(this IServiceCollection services){
            services.AddScoped<IUnityOfWork,UnityOfWork>();
        }
        
    }
