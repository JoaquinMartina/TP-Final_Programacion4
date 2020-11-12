﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppPeliculas;

namespace WebAppPeliculas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppPeliculas.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("WebAppPeliculas.Models.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaEstreno");

                    b.Property<string>("FotoCartel");

                    b.Property<int?>("GeneroId");

                    b.Property<string>("Resumen")
                        .IsRequired();

                    b.Property<string>("Titulo")
                        .IsRequired();

                    b.Property<string>("Trailer")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("WebAppPeliculas.Models.PeliculaActor", b =>
                {
                    b.Property<int>("PersonaId");

                    b.Property<int>("PeliculaId");

                    b.HasKey("PersonaId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("PeliculasActores");
                });

            modelBuilder.Entity("WebAppPeliculas.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Biografia")
                        .IsRequired();

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("FotoCarnet");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("WebAppPeliculas.Models.Pelicula", b =>
                {
                    b.HasOne("WebAppPeliculas.Models.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId");
                });

            modelBuilder.Entity("WebAppPeliculas.Models.PeliculaActor", b =>
                {
                    b.HasOne("WebAppPeliculas.Models.Pelicula", "Pelicula")
                        .WithMany()
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAppPeliculas.Models.Persona", "Actor")
                        .WithMany()
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
