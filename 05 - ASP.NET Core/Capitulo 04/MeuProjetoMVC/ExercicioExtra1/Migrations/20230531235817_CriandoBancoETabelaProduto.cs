using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExercicioExtra1.Migrations
{
    /// <inheritdoc />
    public partial class CriandoBancoETabelaProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataValidade = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrecoCompra = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrecoVenda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantidadeEstoque = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
