using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mlp.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 20, 13, 10, 57, 611, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 20, 13, 10, 57, 614, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 20, 13, 10, 57, 614, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 20, 13, 10, 57, 614, DateTimeKind.Local).AddTicks(7693));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 20, 11, 13, 15, 684, DateTimeKind.Local).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 20, 11, 13, 15, 686, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 20, 11, 13, 15, 686, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DateTimeGroup",
                value: new DateTime(2020, 2, 20, 11, 13, 15, 686, DateTimeKind.Local).AddTicks(7158));
        }
    }
}
