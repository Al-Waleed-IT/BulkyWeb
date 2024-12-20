﻿// <auto-generated />
using BulkyWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241110195726_Initial_Category_ProductToDB")]
    partial class Initial_Category_ProductToDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bulky.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Animation"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Biography"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Crime"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 9,
                            Name = "Documentary"
                        },
                        new
                        {
                            Id = 10,
                            DisplayOrder = 10,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 11,
                            DisplayOrder = 11,
                            Name = "Family"
                        },
                        new
                        {
                            Id = 12,
                            DisplayOrder = 12,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 13,
                            DisplayOrder = 13,
                            Name = "Film Noir"
                        },
                        new
                        {
                            Id = 14,
                            DisplayOrder = 14,
                            Name = "History"
                        },
                        new
                        {
                            Id = 15,
                            DisplayOrder = 15,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 16,
                            DisplayOrder = 16,
                            Name = "Musical"
                        },
                        new
                        {
                            Id = 17,
                            DisplayOrder = 17,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 18,
                            DisplayOrder = 18,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 19,
                            DisplayOrder = 19,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 20,
                            DisplayOrder = 20,
                            Name = "Short"
                        },
                        new
                        {
                            Id = 21,
                            DisplayOrder = 21,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 22,
                            DisplayOrder = 22,
                            Name = "Superhero"
                        },
                        new
                        {
                            Id = 23,
                            DisplayOrder = 23,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 24,
                            DisplayOrder = 24,
                            Name = "War"
                        },
                        new
                        {
                            Id = 25,
                            DisplayOrder = 25,
                            Name = "Western"
                        },
                        new
                        {
                            Id = 26,
                            DisplayOrder = 26,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 27,
                            DisplayOrder = 27,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 28,
                            DisplayOrder = 28,
                            Name = "Animation"
                        },
                        new
                        {
                            Id = 29,
                            DisplayOrder = 29,
                            Name = "Biography"
                        },
                        new
                        {
                            Id = 30,
                            DisplayOrder = 30,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 31,
                            DisplayOrder = 31,
                            Name = "Crime"
                        },
                        new
                        {
                            Id = 32,
                            DisplayOrder = 32,
                            Name = "Documentary"
                        },
                        new
                        {
                            Id = 33,
                            DisplayOrder = 33,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 34,
                            DisplayOrder = 34,
                            Name = "Family"
                        },
                        new
                        {
                            Id = 35,
                            DisplayOrder = 35,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 36,
                            DisplayOrder = 36,
                            Name = "Film Noir"
                        },
                        new
                        {
                            Id = 37,
                            DisplayOrder = 37,
                            Name = "History"
                        },
                        new
                        {
                            Id = 38,
                            DisplayOrder = 38,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 39,
                            DisplayOrder = 39,
                            Name = "Musical"
                        },
                        new
                        {
                            Id = 40,
                            DisplayOrder = 40,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 41,
                            DisplayOrder = 41,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 42,
                            DisplayOrder = 42,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 43,
                            DisplayOrder = 43,
                            Name = "Short"
                        },
                        new
                        {
                            Id = 44,
                            DisplayOrder = 44,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 45,
                            DisplayOrder = 45,
                            Name = "Superhero"
                        },
                        new
                        {
                            Id = 46,
                            DisplayOrder = 46,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 47,
                            DisplayOrder = 47,
                            Name = "War"
                        },
                        new
                        {
                            Id = 48,
                            DisplayOrder = 48,
                            Name = "Western"
                        },
                        new
                        {
                            Id = 49,
                            DisplayOrder = 49,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 50,
                            DisplayOrder = 50,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 51,
                            DisplayOrder = 51,
                            Name = "Animation"
                        },
                        new
                        {
                            Id = 52,
                            DisplayOrder = 52,
                            Name = "Biography"
                        },
                        new
                        {
                            Id = 53,
                            DisplayOrder = 53,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 54,
                            DisplayOrder = 54,
                            Name = "Crime"
                        },
                        new
                        {
                            Id = 55,
                            DisplayOrder = 55,
                            Name = "Documentary"
                        },
                        new
                        {
                            Id = 56,
                            DisplayOrder = 56,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 57,
                            DisplayOrder = 57,
                            Name = "Family"
                        },
                        new
                        {
                            Id = 58,
                            DisplayOrder = 58,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 59,
                            DisplayOrder = 59,
                            Name = "Film Noir"
                        },
                        new
                        {
                            Id = 60,
                            DisplayOrder = 60,
                            Name = "History"
                        },
                        new
                        {
                            Id = 61,
                            DisplayOrder = 61,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 62,
                            DisplayOrder = 62,
                            Name = "Musical"
                        },
                        new
                        {
                            Id = 63,
                            DisplayOrder = 63,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 64,
                            DisplayOrder = 64,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 65,
                            DisplayOrder = 65,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 66,
                            DisplayOrder = 66,
                            Name = "Short"
                        },
                        new
                        {
                            Id = 67,
                            DisplayOrder = 67,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 68,
                            DisplayOrder = 68,
                            Name = "Superhero"
                        },
                        new
                        {
                            Id = 69,
                            DisplayOrder = 69,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 70,
                            DisplayOrder = 70,
                            Name = "War"
                        },
                        new
                        {
                            Id = 71,
                            DisplayOrder = 71,
                            Name = "Western"
                        },
                        new
                        {
                            Id = 72,
                            DisplayOrder = 72,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 73,
                            DisplayOrder = 73,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 74,
                            DisplayOrder = 74,
                            Name = "Animation"
                        },
                        new
                        {
                            Id = 75,
                            DisplayOrder = 75,
                            Name = "Biography"
                        },
                        new
                        {
                            Id = 76,
                            DisplayOrder = 76,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 77,
                            DisplayOrder = 77,
                            Name = "Crime"
                        },
                        new
                        {
                            Id = 78,
                            DisplayOrder = 78,
                            Name = "Documentary"
                        },
                        new
                        {
                            Id = 79,
                            DisplayOrder = 79,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 80,
                            DisplayOrder = 80,
                            Name = "Family"
                        },
                        new
                        {
                            Id = 81,
                            DisplayOrder = 81,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 82,
                            DisplayOrder = 82,
                            Name = "Film Noir"
                        },
                        new
                        {
                            Id = 83,
                            DisplayOrder = 83,
                            Name = "History"
                        },
                        new
                        {
                            Id = 84,
                            DisplayOrder = 84,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 85,
                            DisplayOrder = 85,
                            Name = "Musical"
                        },
                        new
                        {
                            Id = 86,
                            DisplayOrder = 86,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 87,
                            DisplayOrder = 87,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 88,
                            DisplayOrder = 88,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 89,
                            DisplayOrder = 89,
                            Name = "Short"
                        },
                        new
                        {
                            Id = 90,
                            DisplayOrder = 90,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 91,
                            DisplayOrder = 91,
                            Name = "Superhero"
                        },
                        new
                        {
                            Id = 92,
                            DisplayOrder = 92,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 93,
                            DisplayOrder = 93,
                            Name = "War"
                        },
                        new
                        {
                            Id = 94,
                            DisplayOrder = 94,
                            Name = "Western"
                        },
                        new
                        {
                            Id = 95,
                            DisplayOrder = 95,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 96,
                            DisplayOrder = 96,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 97,
                            DisplayOrder = 97,
                            Name = "Animation"
                        },
                        new
                        {
                            Id = 98,
                            DisplayOrder = 98,
                            Name = "Biography"
                        },
                        new
                        {
                            Id = 99,
                            DisplayOrder = 99,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 100,
                            DisplayOrder = 100,
                            Name = "Crime"
                        },
                        new
                        {
                            Id = 101,
                            DisplayOrder = 101,
                            Name = "Documentary"
                        },
                        new
                        {
                            Id = 102,
                            DisplayOrder = 102,
                            Name = "Drama"
                        });
                });

            modelBuilder.Entity("Bulky.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ListPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price100")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price50")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
