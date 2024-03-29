﻿// <auto-generated />
using System;
using Construcao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Construcao.Migrations
{
    [DbContext(typeof(DbConstrucao))]
    [Migration("20240317180335_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Construcao.Models.Categoria", b =>
                {
                    b.Property<long?>("CategoriasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("CategoriasId"));

                    b.Property<string>("Cat_Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cat_Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prioridade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriasId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Construcao.Models.Produto", b =>
                {
                    b.Property<long?>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("ProdutoId"));

                    b.Property<long?>("FK_CategoriaId")
                        .HasColumnType("bigint");

                    b.Property<int>("Preco")
                        .HasColumnType("int");

                    b.Property<string>("Pro_Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pro_Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QntEstoque")
                        .HasColumnType("int");

                    b.HasKey("ProdutoId");

                    b.HasIndex("FK_CategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Construcao.Models.Produto", b =>
                {
                    b.HasOne("Construcao.Models.Categoria", "Categorias")
                        .WithMany("Produtos")
                        .HasForeignKey("FK_CategoriaId");

                    b.Navigation("Categorias");
                });

            modelBuilder.Entity("Construcao.Models.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
