using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IntroAEFCore.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actores",
                columns: new[] { "Id", "FechaNacimineto", "Fortuna", "Nombre" },
                values: new object[,]
                {
                    { 8, new DateTime(1998, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m, "Samuel L. Jackson" },
                    { 9, new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 18000m, "Robert Downey Jr." }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "EnCines", "FechaEstreno", "Titulo" },
                values: new object[,]
                {
                    { 3, false, new DateTime(2019, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avengers Endgame" },
                    { 4, false, new DateTime(2013, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twiligth" },
                    { 5, false, new DateTime(2018, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toy Story 3" }
                });

            migrationBuilder.InsertData(
                table: "Comentarios",
                columns: new[] { "Id", "Contenido", "PeliculaId", "Recomendar" },
                values: new object[,]
                {
                    { 2, "Muy buena pelicuala", 3, true },
                    { 3, "Las peleas son interesantes", 4, true },
                    { 4, "Muy aburrida y lenta", 5, false }
                });

            migrationBuilder.InsertData(
                table: "PeliculasActores",
                columns: new[] { "ActorId", "PeliculaId", "Personaje" },
                values: new object[,]
                {
                    { 8, 4, "Jake Lannister" },
                    { 9, 3, "Nick Fury" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comentarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "PeliculasActores",
                keyColumns: new[] { "ActorId", "PeliculaId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actores",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
