﻿// <auto-generated />
using MVC_assignment_3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_assignment_3.Migrations.MVCVegetablesMigrations
{
    [DbContext(typeof(MVCVegetables))]
    [Migration("20191020023806_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_assignment_3.Models.Vegetables", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvgPricepercupequivalent");

                    b.Property<int>("AvgRetailPrice");

                    b.Property<int>("PreparationYieldFactor");

                    b.Property<int>("Sizeofcupequivalent");

                    b.Property<string>("VegetableForm");

                    b.Property<string>("VegetableName");

                    b.HasKey("Id");

                    b.ToTable("Vegetables");
                });
#pragma warning restore 612, 618
        }
    }
}