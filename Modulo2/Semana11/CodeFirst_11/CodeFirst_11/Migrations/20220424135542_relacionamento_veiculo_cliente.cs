using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst_11.Migrations
{
    public partial class relacionamento_veiculo_cliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idCliente",
                table: "Veiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_idCliente",
                table: "Veiculo",
                column: "idCliente",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Cliente_idCliente",
                table: "Veiculo",
                column: "idCliente",
                principalTable: "Cliente",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Cliente_idCliente",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Veiculo_idCliente",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "idCliente",
                table: "Veiculo");
        }
    }
}
