using Microsoft.AspNetCore.Mvc;
using IntroAEFCore.Entities;
using IntroAEFCore.DTOS;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoBackendCine.Interfaces;

namespace IntroAEFCore.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosController : ControllerBase
    {
        private readonly AplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IUnityOfWork _unityOfWork;

        public GenerosController(IUnityOfWork unityOfWork)
        {
            this._unityOfWork = unityOfWork;
        }
       
/*
        [HttpPost]
        public async Task<ActionResult> Post(GeneroCreacionDTO generoCreacion)
        {
            
                var genero = new Genero (){
                    Nombre = generoCreacion.Nombre;
                }
            
            var genero = mapper.Map<Genero>(generoCreacion);
            context.Add(genero);
            //Realiza la insercion ala base de datos
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost("varios")]
        public async Task<ActionResult> Post(GeneroCreacionDTO[] generoCreacionDTOs)
        {
            var generos = mapper.Map<Genero[]>(generoCreacionDTOs);
            context.AddRange(generos);
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<Genero>>> Get()
        {
            var generos = await context.Generos.ToListAsync();
            return Ok(generos);
        }*/

    }
}