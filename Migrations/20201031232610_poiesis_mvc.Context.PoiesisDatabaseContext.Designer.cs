﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using poiesis_mvc.Context;

namespace poiesis_mvc.Migrations
{
    [DbContext(typeof(PoiesisDBContext))]
    [Migration("20201031232610_poiesis_mvc.Context.PoiesisDatabaseContext")]
    partial class poiesis_mvcContextPoiesisDatabaseContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("poiesis_mvc.Models.Texto", b =>
                {
                    b.Property<int>("idTexto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contenido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<string>("titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTexto");

                    b.HasIndex("idUsuario");

                    b.ToTable("Textos");
                });

            modelBuilder.Entity("poiesis_mvc.Models.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contrasenia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("eleccionDiaYHorario")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("experienciaDeEscritura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("frecuenciaDeLectura")
                        .HasColumnType("int");

                    b.Property<int>("generoDeEscritura")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("poiesis_mvc.Models.Texto", b =>
                {
                    b.HasOne("poiesis_mvc.Models.Usuario", "Usuario")
                        .WithMany("Texto")
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}