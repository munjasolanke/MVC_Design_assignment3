﻿// <auto-generated />
using MVC_assignment_3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_assignment_3.Migrations.MVCAgriSnacksMigrations
{
    [DbContext(typeof(MVCAgriSnacks))]
    [Migration("20191020230911_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_assignment_3.Models.AgriSnacks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CaloriesPerPortion");

                    b.Property<int>("PortionSize");

                    b.Property<int>("PricePerPortion");

                    b.Property<string>("SnackName");

                    b.HasKey("Id");

                    b.ToTable("AgriSnacks");
                });
#pragma warning restore 612, 618
        }
    }
}
