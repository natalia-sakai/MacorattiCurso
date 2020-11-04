using Microsoft.EntityFrameworkCore.Migrations;

namespace Mvc_EFCore.Migrations
{
    public partial class SeedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Alunos (nome, sexo, email, nascimento) VALUES('Natalia', 'Feminino', 'nat@sakai.com', '01/31/2000 07:00:00')");
            migrationBuilder.Sql("INSERT INTO Alunos (nome, sexo, email, nascimento) VALUES('Isabela', 'Feminino', 'isa@bela.com', '08/18/2000 07:00:00')");
            migrationBuilder.Sql("INSERT INTO Alunos (nome, sexo, email, nascimento) VALUES('Jake', 'Masculino', 'jake@enhypen.com', '08/08/2000 07:00:00')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Alunos");
        }
    }
}
