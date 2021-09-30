using Microsoft.EntityFrameworkCore.Migrations;

namespace PadariaApi.Migrations
{
    public partial class CampodescriçãonatabelaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produto",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produto");
        }
    }
}
