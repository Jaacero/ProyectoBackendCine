using Microsoft.AspNetCore.Mvc;
using IntroAEFCore.Entities;
using IntroAEFCore.DTOS;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoBackendCine.Interfaces;
using ProyectoBackendCine.DTOS;

namespace IntroAEFCore.Controllers;
[ApiController]
[Route("api/actores")]
public class ActoresController : ControllerBase
{
    //private readonly AplicationDbContext context;
    //private readonly IMapper mapper;
    private readonly IUnityOfWork _unityOfWork;
    public ActoresController(IUnityOfWork unityOfWork)
    {
        this._unityOfWork = unityOfWork;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Actor>>> Get()
    {
       var actores = await  _unityOfWork.Actores.GetAllActores();
       return Ok(actores);
    }
    [HttpGet("nombre")]
    public async Task<ActionResult<IEnumerable<Actor>>> GetActoresByName(string nombre)
    {
        var actores =  await _unityOfWork.Actores.GetActoresByName(nombre);
        return Ok(actores);
    }
    [HttpGet("NombreyId")]
    public async Task<ActionResult<IEnumerable<ActorDTO>>> GetIdyNombre()
    {
        var actores = await _unityOfWork.Actores.GetByIdyName();
        return Ok(actores);
        
    }
    [HttpGet("conAutoMapper")]
    public async Task<IEnumerable<ActorDTO>> GetActoresAutoMapper()
    {
        return  await _unityOfWork.Actores.GetActorAutoMapper();
       // return Ok(actores);
    }
   
}

