using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuProjetoApi.Migrations
{
    /// <inheritdoc />
    public partial class TornandoTipoObrigatorio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Usuarios",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "usuario",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true,
                oldDefaultValue: "usuario");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "NomeUsuario" },
                values: new object[] { "jose@email.com", "Jose" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Usuarios",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                defaultValue: "usuario",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldDefaultValue: "usuario");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "NomeUsuario" },
                values: new object[] { "ze@email.com", "Zé" });
        }
    }
}
