using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mlp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    DateTimeGroup = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    ReviewerName = table.Column<string>(nullable: true),
                    Rating = table.Column<double>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "DateTimeGroup", "Description", "Image", "Name", "ReviewDate" },
                values: new object[,]
                {
                    { 1, "Leader", new DateTime(2020, 2, 20, 11, 13, 15, 684, DateTimeKind.Local).AddTicks(3980), "I am a strong Pony! Haaaaay!", "rainbowdash.png", "Rainbow Dash", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Pony", new DateTime(2020, 2, 20, 11, 13, 15, 686, DateTimeKind.Local).AddTicks(7086), "I am a shy Pony... hello!", "fluttershy.png", "Fluttershy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Pony", new DateTime(2020, 2, 20, 11, 13, 15, 686, DateTimeKind.Local).AddTicks(7152), "I am a fun Pony!!!", "pinkypie.png", "Pinkie Pie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Pony", new DateTime(2020, 2, 20, 11, 13, 15, 686, DateTimeKind.Local).AddTicks(7158), "I am yet another pony, heya!", "twilightsparkle.png", "Twilight Sparkle", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Content", "ProductId", "Rating", "ReviewerName" },
                values: new object[,]
                {
                    { 1, "I love this pony!!", 1, 5.0, "Carl" },
                    { 2, "I love to feed my pony!!", 2, 5.0, "Amelia" },
                    { 3, "I love to ride my pony!!", 3, 5.0, "Colleen" },
                    { 4, "I wish I had this pony!!", 4, 5.0, "Tim" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
