﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Mvc_EFCore.Migrations
{
    public partial class AddEntidadeTipoSocio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoSocioId",
                table: "Alunos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TipoSocios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DuracaoEmMes = table.Column<int>(nullable: false),
                    TaxaDesconto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSocios", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_TipoSocioId",
                table: "Alunos",
                column: "TipoSocioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_TipoSocios_TipoSocioId",
                table: "Alunos",
                column: "TipoSocioId",
                principalTable: "TipoSocios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_TipoSocios_TipoSocioId",
                table: "Alunos");

            migrationBuilder.DropTable(
                name: "TipoSocios");

            migrationBuilder.DropIndex(
                name: "IX_Alunos_TipoSocioId",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "TipoSocioId",
                table: "Alunos");
        }
    }
}