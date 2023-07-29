using Microsoft.AspNetCore.Mvc;
using IntroAEFCore.Entities;
using IntroAEFCore.DTOS;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoBackendCine.Interfaces;

namespace IntroAEFCore.Controllers;
[ApiController]
[Route("api/peliculas")]
public class PeliculaController : ControllerBase
{
    private readonly IUnityOfWork _unityOfWork;
    private readonly IMapper _mapper;
    public PeliculaController(IUnityOfWork unityOfWork, IMapper mapper)
    {
        _unityOfWork = unityOfWork;
        _mapper = mapper;
    }

    // [HttpPost]
    // public async Task<ActionResult> Post(PeliculaCreationDTO peliculaDTO)
    // {
    //     var pelicula = _mapper.Map<Pelicula>(peliculaDTO);
    //     if (pelicula.Generos is not null)
    //     {
    //         foreach (var genero in pelicula.Generos)
    //         {
    //             //No debe crear nuevos generos, son gneros existentes.
    //             _context.Entry(genero).State = EntityState.Unchanged;
    //         }
    //     }
    //     _context.Add(pelicula);
    //     await _context.SaveChangesAsync();
    //     return Ok();

    // }
    // [HttpGet]
    // public async Task<ActionResult<IEnumerable<Pelicula>>> Get()
    // {
    //     var actores = await _context.Peliculas
    //     .Select(p => new
    //     {
    //         p.Titulo,
    //         p.EnCines,
    //         p.FechaEstreno
    //     }).ToListAsync();
    //     return Ok(actores);
    // }
    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetById(int id)
    {
       var pelicula = _unityOfWork.Peliculas.GetById(id);
       return Ok(pelicula);
    }
}
