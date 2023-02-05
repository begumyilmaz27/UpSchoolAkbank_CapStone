 using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcccessLayer.Migrations
{
    public partial class mig_add_relation_product_satislar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Satislars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Satislars_ProductID",
                table: "Satislars",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Satislars_Products_ProductID",
                table: "Satislars",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Satislars_Products_ProductID",
                table: "Satislars");

            migrationBuilder.DropIndex(
                name: "IX_Satislars_ProductID",
                table: "Satislars");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Satislars");
        }
    }
}
