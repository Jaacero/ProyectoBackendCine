using System.Reflection;
using IntroAEFCore.Entities;
using IntroAEFCore.Entities.Seeding;
using Microsoft.EntityFrameworkCore;

public class AplicationDbContext : DbContext
{
    public AplicationDbContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        SeedingInicial.Seed(modelBuilder);
        
    }
    public DbSet<Genero> Generos =>Set<Genero>();
    public DbSet<Actor> Actores =>Set<Actor>();
    public DbSet<Pelicula> Peliculas =>Set<Pelicula>();
    public DbSet<Comentario> Comentarios =>Set<Comentario>();
    public DbSet<PeliculaActor> PeliculasActores =>Set<PeliculaActor>();
    
}