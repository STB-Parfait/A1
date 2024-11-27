﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("API.Models.Categoria", b =>
                {
                    b.Property<string>("CategoriaId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd",
                            CriadoEm = new DateTime(2024, 11, 28, 9, 45, 11, 918, DateTimeKind.Local).AddTicks(3315),
                            Nome = "Trabalho"
                        },
                        new
                        {
                            CategoriaId = "6d091456-5a2f-4b5a-98fc-f1a3b50a627d",
                            CriadoEm = new DateTime(2024, 11, 29, 9, 45, 11, 918, DateTimeKind.Local).AddTicks(3322),
                            Nome = "Estudos"
                        },
                        new
                        {
                            CategoriaId = "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e",
                            CriadoEm = new DateTime(2024, 11, 30, 9, 45, 11, 918, DateTimeKind.Local).AddTicks(3324),
                            Nome = "Lazer"
                        });
                });

            modelBuilder.Entity("API.Models.Tarefa", b =>
                {
                    b.Property<string>("TarefaId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoriaId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("TarefaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Tarefas");

                    b.HasData(
                        new
                        {
                            TarefaId = "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e",
                            CategoriaId = "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd",
                            CriadoEm = new DateTime(2024, 12, 4, 9, 45, 11, 918, DateTimeKind.Local).AddTicks(3453),
                            Descricao = "Terminar relatório para reunião",
                            Status = "Não iniciada",
                            Titulo = "Concluir relatório"
                        },
                        new
                        {
                            TarefaId = "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e",
                            CategoriaId = "6d091456-5a2f-4b5a-98fc-f1a3b50a627d",
                            CriadoEm = new DateTime(2024, 11, 30, 9, 45, 11, 918, DateTimeKind.Local).AddTicks(3456),
                            Descricao = "Preparar-se para a aula de Angular",
                            Status = "Não iniciada",
                            Titulo = "Estudar Angular"
                        },
                        new
                        {
                            TarefaId = "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f",
                            CategoriaId = "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e",
                            CriadoEm = new DateTime(2024, 12, 11, 9, 45, 11, 918, DateTimeKind.Local).AddTicks(3459),
                            Descricao = "Dar um passeio relaxante no parque",
                            Status = "Não iniciada",
                            Titulo = "Passeio no parque"
                        });
                });

            modelBuilder.Entity("API.Models.Tarefa", b =>
                {
                    b.HasOne("API.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");

                    b.Navigation("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
