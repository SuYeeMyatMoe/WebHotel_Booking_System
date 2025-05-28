using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_Booking_System.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedRoomToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "PriceinDoller", "RoomSize", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "Classic Single Room", "https://www.classichotel.al/wp-content/uploads/2019/07/Optimized-single1.jpg", "Room 1", 1, 30.0, 260, null },
                    { 2, null, "Deluxe Double Room", "https://www.pearlhotelnyc.com/hs-fs/hubfs/2.jpg?width=1488&height=992&name=2.jpg", "Room 2", 2, 50.0, 400, null },
                    { 3, null, "Executive Suite", "https://image-tc.galaxy.tf/wijpeg-eyy6alr2se13uffg555o3iapg/executive-suite-room-2_wide.jpg", "Room 3", 3, 90.0, 600, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
