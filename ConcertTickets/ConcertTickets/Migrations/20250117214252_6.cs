using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcertTickets.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_TicketOffers_TicketOfferId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_TicketOfferId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DiscountApplied",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "NnumTickets",
                table: "Orders",
                newName: "NumTickets");

            migrationBuilder.AlterColumn<bool>(
                name: "HasMemberCard",
                table: "AspNetUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumTickets",
                table: "Orders",
                newName: "NnumTickets");

            migrationBuilder.AddColumn<bool>(
                name: "DiscountApplied",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "HasMemberCard",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TicketOfferId",
                table: "Orders",
                column: "TicketOfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_TicketOffers_TicketOfferId",
                table: "Orders",
                column: "TicketOfferId",
                principalTable: "TicketOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
