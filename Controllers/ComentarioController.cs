using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using IntroAEFCore.Entities;
using AutoMapper;
using IntroAEFCore.DTOS;

namespace IntroAEFCore.Controllers;
    [ApiController]
    [Route("api/peliculas/{peliculaId:int}/comentarios")]


    public class ComentarioController : ControllerBase
    {
        private readonly AplicationDbContext _context;
    private readonly IMapper _mapper;

    public ComentarioController(AplicationDbContext context,IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

         [HttpPost]
         public async Task<ActionResult> PostComentario(int peliculaId,ComentarioCreationDTO comentarioDto)
         {
            var comentario = _mapper.Map<Comentario>(comentarioDto);
            comentario.PeliculaId = peliculaId;
            _context.Add(comentario);
            await _context.SaveChangesAsync();
            return Ok();

         }

    }
