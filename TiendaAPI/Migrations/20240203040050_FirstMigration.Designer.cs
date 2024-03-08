﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiendaAPI.DATA;

#nullable disable

namespace TiendaAPI.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20240203040050_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TiendaAPI.MODELS.Películas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duración")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Género")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Películas");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Director = "Christopher Nolan",
                            Duración = "2 horas 30 minutos",
                            Género = "Acción",
                            Nombre = "Data Seed1",
                            Precio = 2.5
                        },
                        new
                        {
                            ID = 2,
                            Director = "Quentin Tarantino",
                            Duración = "2 horas 15 minutos",
                            Género = "Comedia",
                            Nombre = "Data Seed2",
                            Precio = 3.0
                        },
                        new
                        {
                            ID = 3,
                            Director = "Martin Scorsese",
                            Duración = "2 horas 45 minutos",
                            Género = "Drama",
                            Nombre = "Data Seed3",
                            Precio = 2.75
                        },
                        new
                        {
                            ID = 4,
                            Director = "James Cameron",
                            Duración = "2 horas 20 minutos",
                            Género = "Ciencia Ficción",
                            Nombre = "Data Seed4",
                            Precio = 2.8999999999999999
                        },
                        new
                        {
                            ID = 5,
                            Director = "Greta Gerwig",
                            Duración = "2 horas",
                            Género = "Romance",
                            Nombre = "Data Seed5",
                            Precio = 2.7999999999999998
                        },
                        new
                        {
                            ID = 6,
                            Director = "Alfred Hitchcock",
                            Duración = "2 horas 10 minutos",
                            Género = "Suspense",
                            Nombre = "Data Seed6",
                            Precio = 3.2000000000000002
                        },
                        new
                        {
                            ID = 7,
                            Director = "Tim Burton",
                            Duración = "2 horas 5 minutos",
                            Género = "Fantasía",
                            Nombre = "Data Seed7",
                            Precio = 2.6000000000000001
                        },
                        new
                        {
                            ID = 8,
                            Director = "Steven Spielberg",
                            Duración = "2 horas 40 minutos",
                            Género = "Aventura",
                            Nombre = "Data Seed8",
                            Precio = 3.1000000000000001
                        },
                        new
                        {
                            ID = 9,
                            Director = "David Fincher",
                            Duración = "2 horas 25 minutos",
                            Género = "Misterio",
                            Nombre = "Data Seed9",
                            Precio = 2.9500000000000002
                        },
                        new
                        {
                            ID = 10,
                            Director = "Hayao Miyazaki",
                            Duración = "2 horas 50 minutos",
                            Género = "Animación",
                            Nombre = "Data Seed10",
                            Precio = 3.0499999999999998
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
