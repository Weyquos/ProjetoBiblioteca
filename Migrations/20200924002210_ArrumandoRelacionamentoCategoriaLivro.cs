using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoWPF.Migrations
{
    public partial class ArrumandoRelacionamentoCategoriaLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Categorias_CategoriaId",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_CategoriaId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Livros");

            migrationBuilder.AddColumn<int>(
                name: "LivroId",
                table: "Categorias",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_LivroId",
                table: "Categorias",
                column: "LivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Livros_LivroId",
                table: "Categorias",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Livros_LivroId",
                table: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_LivroId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "LivroId",
                table: "Categorias");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Livros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_CategoriaId",
                table: "Livros",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Categorias_CategoriaId",
                table: "Livros",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
