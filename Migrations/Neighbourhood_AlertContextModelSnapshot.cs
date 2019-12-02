﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Neighbourhood_Alert.Models;

namespace Neighbourhood_Alert.Migrations
{
    [DbContext(typeof(Neighbourhood_AlertContext))]
    partial class Neighbourhood_AlertContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Neighbourhood_Alert.Models.CrimesReported", b =>
                {
                    b.Property<int>("IncidentNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Neighborhood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Offense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RaceOfSuspect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalNumberOfSuspects")
                        .HasColumnType("int");

                    b.Property<string>("Weapons")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IncidentNo");

                    b.ToTable("CrimesReported");
                });
#pragma warning restore 612, 618
        }
    }
}
