using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstate.Data.Migrations
{
    public partial class backToNormal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Bathrooms",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Bedrooms",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "EstMortgage",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl1",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl2",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl3",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl4",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl5",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "HouseImageUrl6",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "YearBuilt",
                table: "Appointments");

            migrationBuilder.CreateTable(
                name: "Homes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HouseImageUrl = table.Column<string>(nullable: true),
                    HouseImageUrl1 = table.Column<string>(nullable: true),
                    HouseImageUrl2 = table.Column<string>(nullable: true),
                    HouseImageUrl3 = table.Column<string>(nullable: true),
                    HouseImageUrl4 = table.Column<string>(nullable: true),
                    HouseImageUrl5 = table.Column<string>(nullable: true),
                    HouseImageUrl6 = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    EstMortgage = table.Column<int>(nullable: false),
                    Bedrooms = table.Column<int>(nullable: false),
                    Bathrooms = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    YearBuilt = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Homes");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Appointments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Bathrooms",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bedrooms",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstMortgage",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl1",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl2",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl3",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl4",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl5",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseImageUrl6",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearBuilt",
                table: "Appointments",
                nullable: true);
        }
    }
}
