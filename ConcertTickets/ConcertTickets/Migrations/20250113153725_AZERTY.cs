using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcertTickets.Migrations
{
    /// <inheritdoc />
    public partial class AZERTY : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasMemberCard",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_TicketOffers_ConcertId",
                table: "TicketOffers",
                column: "ConcertId");

            migrationBuilder.AddForeignKey(
                name: "FK_TicketOffers_Concerts_ConcertId",
                table: "TicketOffers",
                column: "ConcertId",
                principalTable: "Concerts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TicketOffers_Concerts_ConcertId",
                table: "TicketOffers");

            migrationBuilder.DropIndex(
                name: "IX_TicketOffers_ConcertId",
                table: "TicketOffers");

            migrationBuilder.DropColumn(
                name: "HasMemberCard",
                table: "AspNetUsers");
        }
    }
}
