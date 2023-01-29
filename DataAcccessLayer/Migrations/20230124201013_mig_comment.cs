using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcccessLayer.Migrations
{
    public partial class mig_comment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentState = table.Column<bool>(type: "bit", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductID",
                table: "Comments",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
