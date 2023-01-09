﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OregonAnimals;

#nullable disable

namespace OregonAnimals.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OregonAnimals.Models.AnimalModel", b =>
                {
                    b.Property<string>("Animal")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AnimalImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Animal");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("OregonAnimals.Models.SightingModel", b =>
                {
                    b.Property<int>("SightingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SightingID"), 1L, 1);

                    b.Property<int>("AnimalNum")
                        .HasColumnType("int");

                    b.Property<string>("AnimalSightedAnimal")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SightingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SightingID");

                    b.HasIndex("AnimalSightedAnimal");

                    b.ToTable("Sightings");
                });

            modelBuilder.Entity("OregonAnimals.Models.SightingModel", b =>
                {
                    b.HasOne("OregonAnimals.Models.AnimalModel", "AnimalSighted")
                        .WithMany()
                        .HasForeignKey("AnimalSightedAnimal");

                    b.Navigation("AnimalSighted");
                });
#pragma warning restore 612, 618
        }
    }
}
