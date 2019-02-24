using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstate.Data.Migrations
{
    public partial class AddFirstHome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bathrooms",
                table: "Homes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bedrooms",
                table: "Homes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstMortgage",
                table: "Homes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl1",
                table: "Homes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl2",
                table: "Homes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl3",
                table: "Homes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl4",
                table: "Homes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl5",
                table: "Homes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl6",
                table: "Homes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Homes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Homes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearBuilt",
                table: "Homes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bathrooms",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "Bedrooms",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "EstMortgage",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl1",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl2",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl3",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl4",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl5",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl6",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Homes");

            migrationBuilder.DropColumn(
                name: "YearBuilt",
                table: "Homes");
        }
    }
}
