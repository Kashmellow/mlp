using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mlp.Migrations
{
    public partial class SVG_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 14, 13, 45, 271, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 14, 13, 45, 276, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "DateTimeGroup", "Image" },
                values: new object[] { new DateTime(2020, 2, 24, 14, 13, 45, 276, DateTimeKind.Local).AddTicks(9425), "PinkyPie.svg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 14, 13, 45, 276, DateTimeKind.Local).AddTicks(9438));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 14, 9, 28, 372, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 14, 9, 28, 376, DateTimeKind.Local).AddTicks(938));

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
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 14, 9, 28, 376, DateTimeKind.Local).AddTicks(1187));
        }
    }
}
