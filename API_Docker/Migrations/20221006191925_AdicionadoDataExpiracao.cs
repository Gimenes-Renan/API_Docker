using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Docker.Migrations
{
    public partial class AdicionadoDataExpiracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "expiracao",
                table: "categoriateste2",
                type: "timestamp with time zone",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "expiracao",
                table: "categoriateste2");
        }
    }
}
