using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesJardim.NET6.Migrations
{
    public partial class PupularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)" +
                "VALUES('Normal','Lanche feito com igredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao)" +
                "VALUES('Natural','Lanche feito com igredientes integrais e naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
