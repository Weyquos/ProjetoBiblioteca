using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoWPF.Migrations
{
    public partial class ArrumandoHerancasIdMovimentacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Livros_LivroId",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Movimentacao_MovimentacaoId",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Movimentacao_MovimentacaoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_MovimentacaoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Livros_MovimentacaoId",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_LivroId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "MovimentacaoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "LocadoEm",
                table: "Movimentacao");

            migrationBuilder.DropColumn(
                name: "MovimentacaoId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "LivroId",
                table: "Categorias");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Movimentacao",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Livros",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItensMovimentacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    LivroId = table.Column<int>(nullable: true),
                    LocadoEm = table.Column<DateTime>(nullable: false),
                    MovimentacaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensMovimentacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensMovimentacao_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItensMovimentacao_Movimentacao_MovimentacaoId",
                        column: x => x.MovimentacaoId,
                        principalTable: "Movimentacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_UsuarioId",
                table: "Movimentacao",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_CategoriaId",
                table: "Livros",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensMovimentacao_LivroId",
                table: "ItensMovimentacao",
                column: "LivroId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensMovimentacao_MovimentacaoId",
                table: "ItensMovimentacao",
                column: "MovimentacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Categorias_CategoriaId",
                table: "Livros",
                column: "CategoriaId",
                principalTable: "Categorias",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Categorias_CategoriaId",
                table: "Livros");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_Usuarios_UsuarioId",
                table: "Movimentacao");

            migrationBuilder.DropTable(
                name: "ItensMovimentacao");

            migrationBuilder.DropIndex(
                name: "IX_Movimentacao_UsuarioId",
                table: "Movimentacao");

            migrationBuilder.DropIndex(
                name: "IX_Livros_CategoriaId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Movimentacao");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Livros");

            migrationBuilder.AddColumn<int>(
                name: "MovimentacaoId",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LocadoEm",
                table: "Movimentacao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MovimentacaoId",
                table: "Livros",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LivroId",
                table: "Categorias",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_MovimentacaoId",
                table: "Usuarios",
                column: "MovimentacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_MovimentacaoId",
                table: "Livros",
                column: "MovimentacaoId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Movimentacao_MovimentacaoId",
                table: "Livros",
                column: "MovimentacaoId",
                principalTable: "Movimentacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Movimentacao_MovimentacaoId",
                table: "Usuarios",
                column: "MovimentacaoId",
                principalTable: "Movimentacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
