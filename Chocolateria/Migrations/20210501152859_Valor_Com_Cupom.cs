using Microsoft.EntityFrameworkCore.Migrations;

namespace Chocolateria.Migrations
{
    public partial class Valor_Com_Cupom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Valor_Com_Cupom",
                table: "Chocolates",
                nullable: true,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor_Com_Cupom",
                table: "Chocolates");
        }
    }
}
