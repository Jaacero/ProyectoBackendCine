using Microsoft.EntityFrameworkCore;
namespace IntroAEFCore.Entities.Seeding;

public class SeedingInicial
{
    public static void Seed(ModelBuilder modelBuilder){
        var samuelJachson = new Actor(){
            Id = 8,
            Nombre = "Samuel L. Jackson",
            FechaNacimineto = new DateTime(1998,12,21),
            Fortuna = 15000

        };
        var RobertDowneyJunior = new Actor(){
            Id = 9,
            Nombre = "Robert Downey Jr.",
            FechaNacimineto = new DateTime(1965,4,4),
            Fortuna = 18000
        };
        modelBuilder.Entity<Actor>().HasData(samuelJachson,RobertDowneyJunior);
        
        var avenger = new Pelicula(){
            Id = 3,
            Titulo = "Avengers Endgame",
            FechaEstreno = new DateTime(2019,4,22)
        };
        var Twiligth = new Pelicula(){
            Id = 4,
            Titulo = "Twiligth",
            FechaEstreno = new DateTime(2013,4,22)
        };
        var toyStory = new Pelicula(){
            Id = 5,
            Titulo = "Toy Story 3",
            FechaEstreno = new DateTime(2018,10,25)
        };
        modelBuilder.Entity<Pelicula>().HasData(avenger,Twiligth,toyStory);
        //Llenar la tabla intermedia de genero pelicula
       /* var tablaGeneroPelicula = "generopelicula";
        var propiedadGeneroId = "GenerosId";
        var propiedadPeliculasId = "PeliculasId";
        var ficcion = 3;
        //var accion = 1;
        var romance = 4;
        var comedia = 2;

        modelBuilder.Entity(tablaGeneroPelicula).HasData(
            new Dictionary<string,object>{
                [propiedadGeneroId] = ficcion, 
                [propiedadPeliculasId] = avenger.Id

            },
           new Dictionary<string,object>{
                [propiedadGeneroId] = romance,
                [propiedadPeliculasId] = Twiligth.Id
            },
            new Dictionary<string,object>{
                [propiedadGeneroId] = comedia,
                [propiedadPeliculasId] = toyStory.Id
            }
        );*/

         var comentarioAvengers = new Comentario(){
            Id = 2,
            Recomendar = true,
            Contenido = "Muy buena pelicuala",
            PeliculaId = avenger.Id
        };
        var comentarioTwilight = new Comentario(){
            Id = 3,
            Recomendar = true,
            Contenido = "Las peleas son interesantes",
            PeliculaId = Twiligth.Id
        };
        var comentarioToyStory = new Comentario(){
            Id = 4,
            Recomendar = false,
            Contenido = "Muy aburrida y lenta",
            PeliculaId = toyStory.Id
        };
        modelBuilder.Entity<Comentario>().HasData(comentarioAvengers,comentarioTwilight,comentarioToyStory);

        var Robert = new PeliculaActor(){
            PeliculaId = avenger.Id,
            ActorId = RobertDowneyJunior.Id,
            Personaje = "Nick Fury"
        };
        var Samuel = new PeliculaActor(){
            PeliculaId = Twiligth.Id,
            ActorId = samuelJachson.Id,
            Personaje = "Jake Lannister"
        };

        modelBuilder.Entity<PeliculaActor>().HasData(Robert,Samuel);

    }
}
