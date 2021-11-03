using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Chocolateria.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chocolates",
                columns: table => new
                {
                    id_Chocolate = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Valor_Chocolate = table.Column<double>(nullable: false),
                    Quantidade_Disponivel = table.Column<int>(nullable: false),
                    Peso_Chocolate = table.Column<double>(nullable: false),
                    Marca_Chocolate = table.Column<string>(nullable: true),
                    Porcentagem_Cacau = table.Column<double>(nullable: false),
                    Tipo_Chocolate = table.Column<string>(nullable: true),
                    Data_Validade = table.Column<DateTime>(nullable: false),
                    Cupom_Desconto = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chocolates", x => x.id_Chocolate);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chocolates");
        }
    }
}
