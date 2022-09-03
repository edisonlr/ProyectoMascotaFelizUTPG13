﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    public partial class Segundo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInicial",
                table: "Historia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaInicial",
                table: "Historia");
        }
    }
}
