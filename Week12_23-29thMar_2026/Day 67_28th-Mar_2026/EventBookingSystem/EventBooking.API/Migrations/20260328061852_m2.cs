using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventBooking.API.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Location", "Title" },
                values: new object[] { "Annual Gaming Summit", "Mumbai", "World Gaming Summit 2025" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Title" },
                values: new object[] { "Play Resident Evil with Friends", "Bangalore", "Resident Evil Marathon" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Location", "Title" },
                values: new object[] { "Dive into the world of Cyberpunk 2077.", "Delhi", "Cyberpunk Summit" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Location", "Title" },
                values: new object[] { "Annual technology conference featuring industry leaders.", "Mumbai Convention Center", "Tech Conference 2025" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Title" },
                values: new object[] { "Showcase your startup to top investors.", "Bangalore Tech Park", "Startup Pitch Night" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Location", "Title" },
                values: new object[] { "Deep dive into Artificial Intelligence and Machine Learning.", "Delhi Innovation Hub", "AI & ML Summit" });
        }
    }
}
