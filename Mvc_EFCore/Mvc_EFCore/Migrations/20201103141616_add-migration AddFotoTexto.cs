﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Mvc_EFCore.Migrations
{
    public partial class addmigrationAddFotoTexto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Alunos",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Texto",
                table: "Alunos",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Alunos");

            migrationBuilder.DropColumn(
                name: "Texto",
                table: "Alunos");
        }
    }
}
