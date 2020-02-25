using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mlp.Migrations
{
    public partial class RemovedProductReviewDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewDate",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 14, 58, 33, 787, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 14, 58, 33, 790, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 14, 58, 33, 790, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 14, 58, 33, 790, DateTimeKind.Local).AddTicks(2489));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReviewDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 11, 8, 11, 908, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 11, 8, 11, 912, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 11, 8, 11, 912, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 24, 11, 8, 11, 912, DateTimeKind.Local).AddTicks(2512));
        }
    }
}
