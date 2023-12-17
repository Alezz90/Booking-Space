using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceBooking.Migrations
{
    public partial class updaterelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_bookings_CustomerID",
                table: "bookings");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_CustomerID",
                table: "bookings",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_bookings_CustomerID",
                table: "bookings");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_CustomerID",
                table: "bookings",
                column: "CustomerID",
                unique: true);
        }
    }
}
