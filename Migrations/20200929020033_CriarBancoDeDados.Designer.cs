﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoWPF.Models;

namespace ProjetoWPF.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200929020033_CriarBancoDeDados")]
    partial class CriarBancoDeDados
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoWPF.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LivroId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LivroId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ProjetoWPF.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnoPublicacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Editora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MovimentacaoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MovimentacaoId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("ProjetoWPF.Models.Movimentacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LocadoEm")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Movimentacao");
                });

            modelBuilder.Entity("ProjetoWPF.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MovimentacaoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MovimentacaoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProjetoWPF.Models.Categoria", b =>
                {
                    b.HasOne("ProjetoWPF.Models.Livro", null)
                        .WithMany("Categoria")
                        .HasForeignKey("LivroId");
                });

            modelBuilder.Entity("ProjetoWPF.Models.Livro", b =>
                {
                    b.HasOne("ProjetoWPF.Models.Movimentacao", null)
                        .WithMany("Livro")
                        .HasForeignKey("MovimentacaoId");
                });

            modelBuilder.Entity("ProjetoWPF.Models.Usuario", b =>
                {
                    b.HasOne("ProjetoWPF.Models.Movimentacao", null)
                        .WithMany("Usuario")
                        .HasForeignKey("MovimentacaoId");
                });
#pragma warning restore 612, 618
        }
    }
}