using Microsoft.AspNetCore.Mvc;
using IntroAEFCore.Entities;
using IntroAEFCore.DTOS;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace IntroAEFCore.Controllers;
[ApiController]
[Route("api/actores")]
public class ActoresController : ControllerBase
{
    private readonly AplicationDbContext context;
    private readonly IMapper mapper;
    public ActoresController(AplicationDbContext  context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }
    [HttpPost("varios")]
    public async Task<IActionResult> Post(ActorCreationDTO[] actorCreationDTOs){
        var actores = mapper.Map<Actor[]>(actorCreationDTOs);
            context.AddRange(actores);
            await context.SaveChangesAsync();
            return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Actor>>> Get(){
        var actores = await context.Actores.ToListAsync();
        return Ok(actores);
    }

   
}

