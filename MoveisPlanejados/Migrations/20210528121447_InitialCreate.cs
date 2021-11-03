using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoveisPlanejados.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome_Funcionario = table.Column<string>(nullable: false),
                    Status_Funcionario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.FuncionarioId);
                });

            migrationBuilder.CreateTable(
                name: "Moveis",
                columns: table => new
                {
                    Id_Movel = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome_Cliente = table.Column<string>(nullable: false),
                    Nome_Movel = table.Column<string>(nullable: false),
                    Cor_Movel = table.Column<string>(nullable: false),
                    Medidas_Movel = table.Column<string>(nullable: false),
                    Material_Movel = table.Column<string>(nullable: false),
                    Valor_Movel = table.Column<double>(nullable: false),
                    Imagem_Movel = table.Column<string>(nullable: false),
                    Status_Movel = table.Column<string>(nullable: true),
                    FuncionarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moveis", x => x.Id_Movel);
                    table.ForeignKey(
                        name: "FK_Moveis_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Moveis_FuncionarioId",
                table: "Moveis",
                column: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moveis");

            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}
