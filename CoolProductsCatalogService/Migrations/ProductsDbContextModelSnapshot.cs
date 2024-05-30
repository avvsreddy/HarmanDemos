﻿// <auto-generated />
using CoolProductsCatalogService.Model.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoolProductsCatalogService.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    partial class ProductsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoolProductsCatalogService.Model.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Apple",
                            Category = "Mobiles",
                            Country = "India",
                            InStock = true,
                            Name = "IPhone 15",
                            Price = 79999
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Samsung",
                            Category = "Mobiles",
                            Country = "India",
                            InStock = true,
                            Name = "Galaxy S24",
                            Price = 89999
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Apple",
                            Category = "Mobiles",
                            Country = "India",
                            InStock = true,
                            Name = "IPhone 15 pro",
                            Price = 99999
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Apple",
                            Category = "Mobiles",
                            Country = "India",
                            InStock = true,
                            Name = "IPhone 15 Max",
                            Price = 79999
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Apple",
                            Category = "Mobiles",
                            Country = "India",
                            InStock = true,
                            Name = "IPhone 16",
                            Price = 69999
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
