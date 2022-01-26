using Microsoft.EntityFrameworkCore.Migrations;

namespace DevApp.Migrations.Application
{
    public partial class NoAccentUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Libellé",
                table: "Langues",
                newName: "Libelle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Libelle",
                table: "Langues",
                newName: "Libellé");
        }
    }
}
