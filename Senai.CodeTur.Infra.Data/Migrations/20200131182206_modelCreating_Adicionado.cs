using Microsoft.EntityFrameworkCore.Migrations;

namespace Senai.CodeTur.Infra.Data.Migrations
{
    public partial class modelCreating_Adicionado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUsuario", "Email", "Senha", "Tipo" },
                values: new object[] { 1, "fernando.guerra@sp.senai.br", "senai132", "Administrador" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1);
        }
    }
}
