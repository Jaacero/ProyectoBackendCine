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
    private readonly IMapper _mapper;
    public ActoresController(IUnityOfWork unityOfWork, IMapper mapper)
    {
        _unityOfWork = unityOfWork;
        _mapper = mapper;

    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Actor>>> Get()
    {
       var actores = await  _unityOfWork.Actores.GetAllAsync();
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
    [HttpPost]
    public async Task<ActionResult> PostActores(IEnumerable<ActorCreationDTO> actoresDTO)
    {
        var actores = _mapper.Map<IEnumerable<Actor>>(actoresDTO);
         _unityOfWork.Actores.AddRange(actores);
        await _unityOfWork.Save();
        return Ok();
    }
    [HttpPut("{id:int}")]
    public async Task<ActionResult<ActorCreationDTO>> Put(int id,ActorCreationDTO actorCreationDTO)
    {
        var actor = _mapper.Map<Actor>(actorCreationDTO);
        actor.Id = id;
        _unityOfWork.Actores.Update(actor);
        await _unityOfWork.Save();
        return _mapper.Map<ActorCreationDTO>(actor);      
    }
   [HttpDelete("{id:int}/anterior")]
   public async Task<ActionResult> Delete(int id)
   {
    var actor = _unityOfWork.Actores.GetActorById(id);
    if(actor is null){
        return NotFound();
    }
    _unityOfWork.Actores.Remove(actor);
    await _unityOfWork.Save();
    return NoContent();
   }
}

