﻿// <auto-generated />
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240817175335_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Departement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Departement = "IT",
                            Email = "me@gmail.com",
                            Gender = "Male",
                            Name = "Rifqa"
                        },
                        new
                        {
                            Id = 2,
                            Departement = "IT",
                            Email = "bats@gmail.com",
                            Gender = "Male",
                            Name = "Batsu"
                        },
                        new
                        {
                            Id = 3,
                            Departement = "IT",
                            Email = "dim@gmail.com",
                            Gender = "Male",
                            Name = "dimas"
                        },
                        new
                        {
                            Id = 4,
                            Departement = "Finance",
                            Email = "elma@gmail.com",
                            Gender = "Female",
                            Name = "elma"
                        },
                        new
                        {
                            Id = 5,
                            Departement = "Human_Resource",
                            Email = "erni@gmail.com",
                            Gender = "Female",
                            Name = "Agustin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
