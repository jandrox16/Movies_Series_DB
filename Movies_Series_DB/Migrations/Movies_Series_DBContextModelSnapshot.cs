﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies_Series_DB.Data;

namespace Movies_Series_DB.Migrations
{
    [DbContext(typeof(Movies_Series_DBContext))]
    partial class Movies_Series_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Movies_Series_DB.Models.Casting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidosActPpal")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("ApellidosDir")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("FechaNacActPpal");

                    b.Property<DateTime>("FechaNacDir");

                    b.Property<string>("NombreActPpal")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("NombreDir")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PaisActPpal")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PaisDir")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PersonajeActPpal")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("Casting");
                });

            modelBuilder.Entity("Movies_Series_DB.Models.Pelicula", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calificacion");

                    b.Property<DateTime>("FechaSalida");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Sinopsis")
                        .IsRequired();

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("WebStreaming")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Pelicula");
                });
#pragma warning restore 612, 618
        }
    }
}
