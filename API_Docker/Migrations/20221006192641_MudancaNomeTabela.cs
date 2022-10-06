using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Docker.Migrations
{
    public partial class MudancaNomeTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_categoriateste2",
                table: "categoriateste2");

            migrationBuilder.DropColumn(
                name: "valor",
                table: "categoriateste2");

            migrationBuilder.RenameTable(
                name: "categoriateste2",
                newName: "Categorias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "categoriateste2");

            migrationBuilder.AddColumn<double>(
                name: "valor",
                table: "categoriateste2",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_categoriateste2",
                table: "categoriateste2",
                column: "id");
        }
    }
}
