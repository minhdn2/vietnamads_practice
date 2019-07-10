using Microsoft.EntityFrameworkCore.Migrations;

namespace VietnamAds_Practice.Migrations
{
    public partial class updateAdsPostentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nature",
                table: "AdsPost",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price_UnitOfMeasure",
                table: "AdsPost",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Size_Height",
                table: "AdsPost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Size_Length",
                table: "AdsPost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Size_UnitOfMeasure",
                table: "AdsPost",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Size_Width",
                table: "AdsPost",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nature",
                table: "AdsPost");

            migrationBuilder.DropColumn(
                name: "Price_UnitOfMeasure",
                table: "AdsPost");

            migrationBuilder.DropColumn(
                name: "Size_Height",
                table: "AdsPost");

            migrationBuilder.DropColumn(
                name: "Size_Length",
                table: "AdsPost");

            migrationBuilder.DropColumn(
                name: "Size_UnitOfMeasure",
                table: "AdsPost");

            migrationBuilder.DropColumn(
                name: "Size_Width",
                table: "AdsPost");
        }
    }
}
