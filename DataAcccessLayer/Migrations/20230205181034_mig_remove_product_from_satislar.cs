using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcccessLayer.Migrations
{
    public partial class mig_remove_product_from_satislar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product",
                table: "Satislars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Product",
                table: "Satislars",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
