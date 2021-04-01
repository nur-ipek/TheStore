using Microsoft.EntityFrameworkCore.Migrations;

namespace TheStore.Data.Migrations
{
    public partial class SeedMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Individual" });

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Sole Proprietorship" });

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Limited or Incorporated" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
