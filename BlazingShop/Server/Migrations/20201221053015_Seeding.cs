using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazingShop.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 1, "book", "Books", "books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 2, "camera-slr", "Electronics", "electronics" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 3, "aperture", "Video Games", "video-games" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 12, 21, 6, 30, 14, 409, DateTimeKind.Local).AddTicks(7837), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hitchhiker's Guide to the Galaxy (sometimes referred to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series created by Douglas Adams.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", false, false, 19.99m, 9.99m, "The Hitchhiker's Guide to the Galaxy" },
                    { 2, 1, new DateTime(2020, 12, 21, 6, 30, 14, 413, DateTimeKind.Local).AddTicks(149), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", false, false, 14.99m, 7.99m, "Ready Player One" },
                    { 3, 1, new DateTime(2020, 12, 21, 6, 30, 14, 413, DateTimeKind.Local).AddTicks(188), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.", "https://upload.wikimedia.org/wikipedia/en/c/c3/1984first.jpg", false, false, 0m, 6.99m, "Nineteen Eighty-Four" },
                    { 4, 2, new DateTime(2020, 12, 21, 6, 30, 14, 413, DateTimeKind.Local).AddTicks(193), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd., later known as Pentax Corporation, between 1964 and 1976.", "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg", false, false, 249.00m, 166.66m, "Pentax Spotmatic" },
                    { 5, 2, new DateTime(2020, 12, 21, 6, 30, 14, 413, DateTimeKind.Local).AddTicks(196), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", false, false, 299m, 159.99m, "Xbox" },
                    { 6, 2, new DateTime(2020, 12, 21, 6, 30, 14, 413, DateTimeKind.Local).AddTicks(209), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", false, false, 400m, 73.74m, "Super Nintendo Entertainment System" },
                    { 7, 3, new DateTime(2020, 12, 21, 6, 30, 14, 413, DateTimeKind.Local).AddTicks(212), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", false, false, 29.99m, 8.19m, "Half-Life 2" },
                    { 8, 3, new DateTime(2020, 12, 21, 6, 30, 14, 413, DateTimeKind.Local).AddTicks(215), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", false, false, 24.99m, 9.99m, "Diablo II" },
                    { 9, 3, new DateTime(2020, 12, 21, 6, 30, 14, 413, DateTimeKind.Local).AddTicks(218), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", false, false, 0m, 14.99m, "Day of the Tentacle" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
