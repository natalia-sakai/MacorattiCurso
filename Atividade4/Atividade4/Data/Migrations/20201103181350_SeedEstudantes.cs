using Microsoft.EntityFrameworkCore.Migrations;

namespace Atividade4.Data.Migrations
{
    public partial class SeedEstudantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Cursos(Titulo, Creditos) VALUES('Quimica',4)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Cursos");
        }
    }
}
