using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Categories", "Developer", "DiscountPercentage", "ImageGame", "Name", "Price", "Publisher", "ReleaseDate", "Review" },
                values: new object[,]
                {
                    { 1, "Action, Adventure, RPG", "Ubisoft Montreal", 15m, "/public/call of duty.jpeg", "Call Of Duty", 59.99m, "Ubisoft", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "242,544" },
                    { 2, "Action, RPG", "CD Projekt", 10m, "/public/dead space.jpeg", "Dead Space", 49.99m, "CD Projekt", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "345,542" },
                    { 3, "Action, RPG", "CD Projekt", 20m, "/public/duty after school.jpeg", "Duty After School", 29.99m, "CD Projekt", new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Very Positive" },
                    { 4, "Sports, Simulation", "EA Vancouver", 10m, "/public/Enshrouded.jpeg", "Enshrounded", 39.99m, "Electronic Arts", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Positive" },
                    { 5, "Action, Adventure", "Rockstar Studios", 15m, "/public/God Of War.jpeg", "God Of War", 69.99m, "Rockstar Games", new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Very Positive" },
                    { 6, "Action, Shooter", "Infinity Ward", 10m, "/public/hogwart.jepg", "Hogwart", 49.99m, "Activision", new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Positive" },
                    { 7, "Sandbox, Adventure", "Mojang Studios", 25m, "/public/knivea out.jpeg", "Knivea Out", 19.99m, "Mojang", new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwhelmingly Positive" },
                    { 8, "Casual, Party Game", "InnerSloth", 50m, "/public/League Legend.jpeg", "League Legend", 4.99m, "InnerSloth", new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Very Positive" },
                    { 9, "MOBA", "Riot Games", 0m, "/public/Palworld.jpeg", "Palworld", 0m, "Riot Games", new DateTime(2009, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Very Positive" },
                    { 10, "Action, Shooter", "ProductId Software", 20m, "/public/TEKKEN 8.jpeg", "TEKKEN 8", 59.99m, "Bethesda Softworks", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Very Positive" },
                    { 11, "Action, Shooter", "ProductId Software", 20m, "/public/tntm.jpeg", "Till The End Of The Moonl", 59.99m, "Bethesda Softworks", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "21,543" },
                    { 12, "Action, Shooter", "ProductId Software", 20m, "/public/Tom Clancy's Rainbow.jpeg", "Tom Clancy's Rainbow", 59.99m, "Bethesda Softworks", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "876,234" },
                    { 13, "Action, Shooter", "ProductId Software", 20m, "/public/War Thunder.jpeg", "War Thunderl", 59.99m, "Bethesda Softworks", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "143,756" },
                    { 14, "Action, Shooter", "ProductId Software", 20m, "/public/World of Tanks.jpeg", "World of Tanks", 59.99m, "Bethesda Softworks", new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "566,34" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
