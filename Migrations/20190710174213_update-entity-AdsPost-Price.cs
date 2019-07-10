using Microsoft.EntityFrameworkCore.Migrations;

namespace VietnamAds_Practice.Migrations
{
    public partial class updateentityAdsPostPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "AdsPost",
                nullable: true,
                oldClrType: typeof(float),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "AdsPost",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);
        }
    }
}
