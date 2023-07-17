using Microsoft.AspNetCore.Mvc;
using IntroAEFCore.Entities;
using IntroAEFCore.DTOS;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace IntroAEFCore.Controllers;
    [ApiController]
    [Route("api/peliculas")]
    public class PeliculaController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        private readonly IMapper _mapper;
        public PeliculaController(AplicationDbContext context , IMapper automapper)
        {
            this._context = context;
            this._mapper = automapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(PeliculaCreationDTO peliculaDTO){
           var pelicula = _mapper.Map<Pelicula>(peliculaDTO);
           if(pelicula.Generos is not null){
            foreach(var genero in pelicula.Generos){
                //No debe crear nuevos generos, son gneros existentes.
                _context.Entry(genero).State = EntityState.Unchanged;
            }
           }
          _context.Add(pelicula);
          await _context.SaveChangesAsync();
          return Ok();

        }
    }
