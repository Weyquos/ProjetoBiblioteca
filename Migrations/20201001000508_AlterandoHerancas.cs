using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoWPF.Migrations
{
    public partial class AlterandoHerancas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensMovimentacao_Livros_LivroId",
                table: "ItensMovimentacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_Usuarios_UsuarioId",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_Movimentacao_UsuarioId",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_ItensMovimentacao_LivroId",
                table: "ItensMovimentacao");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Movimentacao");

            migrationBuilder.DropColumn(
                name: "LivroId",
                table: "ItensMovimentacao");

            migrationBuilder.AddColumn<int>(
                name: "LivroId",
                table: "Movimentacao",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "ItensMovimentacao",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_LivroId",
                table: "Movimentacao",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensMovimentacao_UsuarioId",
                table: "ItensMovimentacao",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensMovimentacao_Usuarios_UsuarioId",
                table: "ItensMovimentacao",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_Livros_LivroId",
                table: "Movimentacao",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensMovimentacao_Usuarios_UsuarioId",
                table: "ItensMovimentacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_Livros_LivroId",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_Movimentacao_LivroId",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_ItensMovimentacao_UsuarioId",
                table: "ItensMovimentacao");

            migrationBuilder.DropColumn(
                name: "LivroId",
                table: "Movimentacao");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "ItensMovimentacao");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Movimentacao",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LivroId",
                table: "ItensMovimentacao",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_UsuarioId",
                table: "Movimentacao",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensMovimentacao_LivroId",
                table: "ItensMovimentacao",
                column: "LivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensMovimentacao_Livros_LivroId",
                table: "ItensMovimentacao",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_Usuarios_UsuarioId",
                table: "Movimentacao",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
