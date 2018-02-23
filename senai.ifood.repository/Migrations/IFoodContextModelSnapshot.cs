﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using senai.ifood.repository.Context;
using System;

namespace senai.ifood.repository.Migrations
{
    [DbContext(typeof(IFoodContext))]
    partial class IFoodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("senai.ifood.domain.Entities.ClienteDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("senai.ifood.domain.Entities.EspecialidadeDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("senai.ifood.domain.Entities.PermissaoDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Permissoes");
                });

            modelBuilder.Entity("senai.ifood.domain.Entities.ProdutoRestauranteDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("RestauranteId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("RestauranteId");

                    b.ToTable("ProdutosRestaurantes");
                });

            modelBuilder.Entity("senai.ifood.domain.Entities.RestauranteDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("EspecialidadeId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Restaurantes");
                });

            modelBuilder.Entity("senai.ifood.domain.Entities.UsuarioDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("senai.ifood.domain.Entities.UsuarioPermissaoDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<int>("PermissaoId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("PermissaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuariosPermissoes");
                });

            modelBuilder.Entity("senai.ifood.domain.Entities.ClienteDomain", b =>
                {
                    b.HasOne("senai.ifood.domain.Entities.UsuarioDomain", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("senai.ifood.domain.Entities.ProdutoRestauranteDomain", b =>
                {
                    b.HasOne("senai.ifood.domain.Entities.RestauranteDomain", "Restaurante")
                        .WithMany("ProdutosRestaurante")
                        .HasForeignKey("RestauranteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("senai.ifood.domain.Entities.RestauranteDomain", b =>
                {
                    b.HasOne("senai.ifood.domain.Entities.EspecialidadeDomain", "Especialidade")
                        .WithMany("Restaurantes")
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("senai.ifood.domain.Entities.UsuarioDomain", "Usuario")
                        .WithMany("Restaurantes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("senai.ifood.domain.Entities.UsuarioPermissaoDomain", b =>
                {
                    b.HasOne("senai.ifood.domain.Entities.PermissaoDomain", "Permissao")
                        .WithMany("UsuariosPermissoes")
                        .HasForeignKey("PermissaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("senai.ifood.domain.Entities.UsuarioDomain", "Usuario")
                        .WithMany("UsuariosPermissoes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
