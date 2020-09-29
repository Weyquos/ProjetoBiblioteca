using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoWPF.Migrations
{
    public partial class LivroEmMovimentacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovimentacaoId",
                table: "Livros",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_MovimentacaoId",
                table: "Livros",
                column: "MovimentacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Movimentacao_MovimentacaoId",
                table: "Livros",
                column: "MovimentacaoId",
                principalTable: "Movimentacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Movimentacao_MovimentacaoId",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_MovimentacaoId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "MovimentacaoId",
                table: "Livros");
        }
    }
}
