using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConcertTickets.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumTickets = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ConcertId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketOffers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NnumTickets = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    DiscountApplied = table.Column<bool>(type: "bit", nullable: false),
                    TicketOfferId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_TicketOffers_TicketOfferId",
                        column: x => x.TicketOfferId,
                        principalTable: "TicketOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "Artist", "Date", "Location" },
                values: new object[,]
                {
                    { 1, "Taylor Swift", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Koning Boudewijn Stadion, Brussel" },
                    { 2, "Taylor Swift", new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Koning Boudewijn Stadion, Brussel" },
                    { 3, "Charli XCX", new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vorst Nationaal, Brussel" },
                    { 4, "Compact Disk Dummies", new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ancienne Belgique, Brussel" },
                    { 5, "Compact Disk Dummies", new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ancienne Belgique, Brussel" },
                    { 6, "Coldplay", new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sportpaleis, Antwerpen" },
                    { 7, "Dua Lipa", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werchter" },
                    { 8, "Dua Lipa", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Werchter" }
                });

            migrationBuilder.InsertData(
                table: "TicketOffers",
                columns: new[] { "Id", "ConcertId", "NumTickets", "Price", "TicketType" },
                values: new object[,]
                {
                    { 1, 1, 10, 200.0, "Golden Circle" },
                    { 2, 1, 50, 50.0, "Standing" },
                    { 3, 1, 60, 60.0, "Seated" },
                    { 4, 2, 1000, 200.0, "Golden Circle" },
                    { 5, 2, 19000, 50.0, "Standing" },
                    { 6, 2, 20000, 60.0, "Seated" },
                    { 7, 3, 0, 100.0, "Golden Circle" },
                    { 8, 3, 0, 28.0, "Standing" },
                    { 9, 3, 0, 32.0, "Seated" },
                    { 10, 4, 2000, 28.0, "Standing" },
                    { 11, 4, 1800, 32.0, "Seated" },
                    { 12, 5, 2000, 28.0, "Standing" },
                    { 13, 5, 7800, 32.0, "Seated" },
                    { 14, 6, 400, 150.0, "Golden Circle" },
                    { 15, 6, 4000, 65.0, "Standing" },
                    { 16, 6, 4000, 55.0, "Seated" },
                    { 17, 7, 1000, 124.0, "Golden Circle" },
                    { 18, 7, 20000, 67.0, "Standing" },
                    { 19, 8, 2000, 36.0, "Standing" },
                    { 20, 8, 7800, 40.0, "Seated" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TicketOfferId",
                table: "Orders",
                column: "TicketOfferId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Concerts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "TicketOffers");
        }
    }
}
