﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

namespace WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210414155510_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.Departamento", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sigla")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Departamento");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Administrativo",
                            sigla = "SP"
                        },
                        new
                        {
                            id = 2,
                            nome = "Financeiro",
                            sigla = "SP"
                        },
                        new
                        {
                            id = 3,
                            nome = "Recursos Humanos",
                            sigla = "SP"
                        },
                        new
                        {
                            id = 4,
                            nome = "Departamento Comercial",
                            sigla = "SP"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.Funcionario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Funcionario");

                    b.HasData(
                        new
                        {
                            id = 1,
                            DepartamentoId = 3,
                            RG = "11554454x",
                            foto = "Enviar",
                            nome = "Marcos"
                        },
                        new
                        {
                            id = 2,
                            DepartamentoId = 2,
                            RG = "81584454x",
                            foto = "Enviar",
                            nome = "João"
                        },
                        new
                        {
                            id = 3,
                            DepartamentoId = 1,
                            RG = "31759454x",
                            foto = "Enviar",
                            nome = "Clara"
                        },
                        new
                        {
                            id = 4,
                            DepartamentoId = 4,
                            RG = "51534454x",
                            foto = "Enviar",
                            nome = "Matheus"
                        },
                        new
                        {
                            id = 5,
                            DepartamentoId = 3,
                            RG = "11254464x",
                            foto = "Enviar",
                            nome = "Maria"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.Funcionario", b =>
                {
                    b.HasOne("WebAPI.Models.Departamento", "Departamento")
                        .WithMany("Funcionarios")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("WebAPI.Models.Departamento", b =>
                {
                    b.Navigation("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
