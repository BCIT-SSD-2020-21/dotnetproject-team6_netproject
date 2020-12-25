using Microsoft.EntityFrameworkCore.Migrations;

namespace GiftWishlist.Data.Migrations
{
    public partial class SeedDatabaseTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ImageThumbnailUrl", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, "Test Item 1 description", "http://placehold.it/500x300", "http://placehold.it/750x500", "Test Item 1", 10.10m });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ImageThumbnailUrl", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, "Test Item 2 description", "http://placehold.it/500x300", "http://placehold.it/750x500", "Test Item 2", 100m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
