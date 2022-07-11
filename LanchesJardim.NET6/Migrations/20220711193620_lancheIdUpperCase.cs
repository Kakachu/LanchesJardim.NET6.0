using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesJardim.NET6.Migrations
{
    public partial class lancheIdUpperCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Lanches_lancheId",
                table: "PedidoDetalhes");

            migrationBuilder.RenameColumn(
                name: "lancheId",
                table: "PedidoDetalhes",
                newName: "LancheId");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoDetalhes_lancheId",
                table: "PedidoDetalhes",
                newName: "IX_PedidoDetalhes_LancheId");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Lanches_LancheId",
                table: "PedidoDetalhes",
                column: "LancheId",
                principalTable: "Lanches",
                principalColumn: "LancheId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Lanches_LancheId",
                table: "PedidoDetalhes");

            migrationBuilder.RenameColumn(
                name: "LancheId",
                table: "PedidoDetalhes",
                newName: "lancheId");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoDetalhes_LancheId",
                table: "PedidoDetalhes",
                newName: "IX_PedidoDetalhes_lancheId");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Lanches_lancheId",
                table: "PedidoDetalhes",
                column: "lancheId",
                principalTable: "Lanches",
                principalColumn: "LancheId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
