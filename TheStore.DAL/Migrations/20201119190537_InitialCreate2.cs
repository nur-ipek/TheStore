using Microsoft.EntityFrameworkCore.Migrations;

namespace TheStore.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Towns_TownId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Customers_CustomerId",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_CustomerId",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CityId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Cities_TownId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "TownId",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Towns",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Sellers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Sellers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Sellers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Sellers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "Sellers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Towns_CityId",
                table: "Towns",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_CityId",
                table: "Sellers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CityId",
                table: "Customers",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Cities_CityId",
                table: "Sellers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Cities_CityId",
                table: "Towns",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Cities_CityId",
                table: "Sellers");

            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Cities_CityId",
                table: "Towns");

            migrationBuilder.DropIndex(
                name: "IX_Towns_CityId",
                table: "Towns");

            migrationBuilder.DropIndex(
                name: "IX_Sellers_CityId",
                table: "Sellers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CityId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Sellers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Sellers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TownId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_CustomerId",
                table: "Sellers",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CityId",
                table: "Customers",
                column: "CityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_TownId",
                table: "Cities",
                column: "TownId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Towns_TownId",
                table: "Cities",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Customers_CustomerId",
                table: "Sellers",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
