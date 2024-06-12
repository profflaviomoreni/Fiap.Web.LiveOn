using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Web.LiveOn.Migrations
{
    /// <inheritdoc />
    public partial class AddModeloVeiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MODELOS",
                columns: table => new
                {
                    ModeloVeiculoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NomeModelo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    MontadoraId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    AnoModelo = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TipoCombustivel = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MODELOS", x => x.ModeloVeiculoId);
                    table.ForeignKey(
                        name: "FK_MODELOS_MONTADORA_MontadoraId",
                        column: x => x.MontadoraId,
                        principalTable: "MONTADORA",
                        principalColumn: "MontadoraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MODELOS_MontadoraId",
                table: "MODELOS",
                column: "MontadoraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MODELOS");
        }
    }
}
