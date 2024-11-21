﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SwissMex.RazorPages.Data;

#nullable disable

namespace SwissMex.RazorPages.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241121181724_InitDatabase")]
    partial class InitDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SwissMex.RazorPages.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2024, 11, 21, 12, 17, 23, 852, DateTimeKind.Local).AddTicks(9441),
                            DisplayOrder = 1,
                            Name = "Siembra"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2024, 11, 21, 12, 17, 23, 852, DateTimeKind.Local).AddTicks(9457),
                            DisplayOrder = 2,
                            Name = "Cosecha"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTime = new DateTime(2024, 11, 21, 12, 17, 23, 852, DateTimeKind.Local).AddTicks(9459),
                            DisplayOrder = 3,
                            Name = "Aspersión"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}