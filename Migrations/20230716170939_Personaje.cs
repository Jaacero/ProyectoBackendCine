using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroAEFCore.Migrations
{
    /// <inheritdoc />
    public partial class Personaje : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Personaje",
                table: "PeliculasActores",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Personaje",
                table: "PeliculasActores");
        }
    }
}
