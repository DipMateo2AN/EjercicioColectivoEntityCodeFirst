﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modelo;

#nullable disable

namespace Modelo.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ColectivoPasajero", b =>
                {
                    b.Property<int>("ColectivoId")
                        .HasColumnType("int");

                    b.Property<int>("PasajerosPasajeroId")
                        .HasColumnType("int");

                    b.HasKey("ColectivoId", "PasajerosPasajeroId");

                    b.HasIndex("PasajerosPasajeroId");

                    b.ToTable("ColectivoPasajero");
                });

            modelBuilder.Entity("Modelo.Colectivo", b =>
                {
                    b.Property<int>("ColectivoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColectivoId"));

                    b.Property<int>("CantidadAsientos")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColectivoId");

                    b.ToTable("Colectivos");
                });

            modelBuilder.Entity("Modelo.Pasajero", b =>
                {
                    b.Property<int>("PasajeroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PasajeroId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PasajeroId");

                    b.ToTable("Pasajeros");
                });

            modelBuilder.Entity("ColectivoPasajero", b =>
                {
                    b.HasOne("Modelo.Colectivo", null)
                        .WithMany()
                        .HasForeignKey("ColectivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Pasajero", null)
                        .WithMany()
                        .HasForeignKey("PasajerosPasajeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
