using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Booking_System.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingPriceName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Rooms",
                newName: "PriceinDoller");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PriceinDoller",
                table: "Rooms",
                newName: "Price");
        }
    }
}
