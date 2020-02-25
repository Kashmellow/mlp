using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mlp.Migrations
{
    public partial class SVG_Addition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateTimeGroup", "Image" },
                values: new object[] { new DateTime(2020, 2, 24, 14, 9, 28, 372, DateTimeKind.Local).AddTicks(9475), "RainbowDash.svg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateTimeGroup", "Image" },
                values: new object[] { new DateTime(2020, 2, 24, 14, 9, 28, 376, DateTimeKind.Local).AddTicks(938), "FlutterShy.svg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateTimeGroup", "Image" },
                values: new object[] { new DateTime(2020, 2, 24, 14, 9, 28, 376, DateTimeKind.Local).AddTicks(1178), "PinkiePie.svg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "DateTimeGroup", "Image" },
                values: new object[] { new DateTime(2020, 2, 24, 14, 9, 28, 376, DateTimeKind.Local).AddTicks(1187), "TwilightSparkle.svg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "DateTimeGroup", "Image" },
                values: new object[] { new DateTime(2020, 2, 24, 11, 8, 11, 908, DateTimeKind.Local).AddTicks(7466), "rainbowdash.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "DateTimeGroup", "Image" },
                values: new object[] { new DateTime(2020, 2, 24, 11, 8, 11, 912, DateTimeKind.Local).AddTicks(2422), "fluttershy.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateTimeGroup", "Image" },
                values: new object[] { new DateTime(2020, 2, 24, 11, 8, 11, 912, DateTimeKind.Local).AddTicks(2505), "pinkypie.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "DateTimeGroup", "Image" },
                values: new object[] { new DateTime(2020, 2, 24, 11, 8, 11, 912, DateTimeKind.Local).AddTicks(2512), "twilightsparkle.png" });
        }
    }
}
