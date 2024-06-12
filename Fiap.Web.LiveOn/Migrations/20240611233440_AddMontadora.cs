using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Web.LiveOn.Migrations
{
    /// <inheritdoc />
    public partial class AddMontadora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MONTADORA",
                columns: table => new
                {
                    MontadoraId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(450)", nullable: false),
                    PaisOrigem = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    AnoFundacao = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MONTADORA", x => x.MontadoraId);
                });

            migrationBuilder.CreateIndex(
                name: "IDX_PAIS_ANO",
                table: "MONTADORA",
                columns: new[] { "PaisOrigem", "AnoFundacao" });

            migrationBuilder.CreateIndex(
                name: "IX_MONTADORA_Nome",
                table: "MONTADORA",
                column: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MONTADORA");
        }
    }
}
