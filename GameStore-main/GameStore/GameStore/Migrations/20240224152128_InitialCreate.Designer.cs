﻿// <auto-generated />
using System;
using GameStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameStore.Migrations
{
    [DbContext(typeof(GameStoreContext))]
    [Migration("20240224152128_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameStore.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Categories")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Developer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiscountPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImageGame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Categories = "Action, Adventure, RPG",
                            Developer = "Ubisoft Montreal",
                            DiscountPercentage = 15m,
                            ImageGame = "/public/call of duty.jpeg",
                            Name = "Call Of Duty",
                            Price = 59.99m,
                            Publisher = "Ubisoft",
                            ReleaseDate = new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "242,544"
                        },
                        new
                        {
                            ProductId = 2,
                            Categories = "Action, RPG",
                            Developer = "CD Projekt",
                            DiscountPercentage = 10m,
                            ImageGame = "/public/dead space.jpeg",
                            Name = "Dead Space",
                            Price = 49.99m,
                            Publisher = "CD Projekt",
                            ReleaseDate = new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "345,542"
                        },
                        new
                        {
                            ProductId = 3,
                            Categories = "Action, RPG",
                            Developer = "CD Projekt",
                            DiscountPercentage = 20m,
                            ImageGame = "/public/duty after school.jpeg",
                            Name = "Duty After School",
                            Price = 29.99m,
                            Publisher = "CD Projekt",
                            ReleaseDate = new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "Very Positive"
                        },
                        new
                        {
                            ProductId = 4,
                            Categories = "Sports, Simulation",
                            Developer = "EA Vancouver",
                            DiscountPercentage = 10m,
                            ImageGame = "/public/Enshrouded.jpeg",
                            Name = "Enshrounded",
                            Price = 39.99m,
                            Publisher = "Electronic Arts",
                            ReleaseDate = new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "Positive"
                        },
                        new
                        {
                            ProductId = 5,
                            Categories = "Action, Adventure",
                            Developer = "Rockstar Studios",
                            DiscountPercentage = 15m,
                            ImageGame = "/public/God Of War.jpeg",
                            Name = "God Of War",
                            Price = 69.99m,
                            Publisher = "Rockstar Games",
                            ReleaseDate = new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "Very Positive"
                        },
                        new
                        {
                            ProductId = 6,
                            Categories = "Action, Shooter",
                            Developer = "Infinity Ward",
                            DiscountPercentage = 10m,
                            ImageGame = "/public/hogwart.jepg",
                            Name = "Hogwart",
                            Price = 49.99m,
                            Publisher = "Activision",
                            ReleaseDate = new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "Positive"
                        },
                        new
                        {
                            ProductId = 7,
                            Categories = "Sandbox, Adventure",
                            Developer = "Mojang Studios",
                            DiscountPercentage = 25m,
                            ImageGame = "/public/knivea out.jpeg",
                            Name = "Knivea Out",
                            Price = 19.99m,
                            Publisher = "Mojang",
                            ReleaseDate = new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "Overwhelmingly Positive"
                        },
                        new
                        {
                            ProductId = 8,
                            Categories = "Casual, Party Game",
                            Developer = "InnerSloth",
                            DiscountPercentage = 50m,
                            ImageGame = "/public/League Legend.jpeg",
                            Name = "League Legend",
                            Price = 4.99m,
                            Publisher = "InnerSloth",
                            ReleaseDate = new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "Very Positive"
                        },
                        new
                        {
                            ProductId = 9,
                            Categories = "MOBA",
                            Developer = "Riot Games",
                            DiscountPercentage = 0m,
                            ImageGame = "/public/Palworld.jpeg",
                            Name = "Palworld",
                            Price = 0m,
                            Publisher = "Riot Games",
                            ReleaseDate = new DateTime(2009, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "Very Positive"
                        },
                        new
                        {
                            ProductId = 10,
                            Categories = "Action, Shooter",
                            Developer = "ProductId Software",
                            DiscountPercentage = 20m,
                            ImageGame = "/public/TEKKEN 8.jpeg",
                            Name = "TEKKEN 8",
                            Price = 59.99m,
                            Publisher = "Bethesda Softworks",
                            ReleaseDate = new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "Very Positive"
                        },
                        new
                        {
                            ProductId = 11,
                            Categories = "Action, Shooter",
                            Developer = "ProductId Software",
                            DiscountPercentage = 20m,
                            ImageGame = "/public/tntm.jpeg",
                            Name = "Till The End Of The Moonl",
                            Price = 59.99m,
                            Publisher = "Bethesda Softworks",
                            ReleaseDate = new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "21,543"
                        },
                        new
                        {
                            ProductId = 12,
                            Categories = "Action, Shooter",
                            Developer = "ProductId Software",
                            DiscountPercentage = 20m,
                            ImageGame = "/public/Tom Clancy's Rainbow.jpeg",
                            Name = "Tom Clancy's Rainbow",
                            Price = 59.99m,
                            Publisher = "Bethesda Softworks",
                            ReleaseDate = new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "876,234"
                        },
                        new
                        {
                            ProductId = 13,
                            Categories = "Action, Shooter",
                            Developer = "ProductId Software",
                            DiscountPercentage = 20m,
                            ImageGame = "/public/War Thunder.jpeg",
                            Name = "War Thunderl",
                            Price = 59.99m,
                            Publisher = "Bethesda Softworks",
                            ReleaseDate = new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "143,756"
                        },
                        new
                        {
                            ProductId = 14,
                            Categories = "Action, Shooter",
                            Developer = "ProductId Software",
                            DiscountPercentage = 20m,
                            ImageGame = "/public/World of Tanks.jpeg",
                            Name = "World of Tanks",
                            Price = 59.99m,
                            Publisher = "Bethesda Softworks",
                            ReleaseDate = new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Review = "566,34"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
