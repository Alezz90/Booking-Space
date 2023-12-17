using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceBooking.Migrations
{
    public partial class updatecolmcapacity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gapacity",
                table: "Spaces",
                newName: "Capacity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "Spaces",
                newName: "Gapacity");
        }
    }
}
