using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mlp.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Content", "ProductId", "Rating", "ReviewerName" },
                values: new object[,]
                {
                    { 5, "I love collecting all sorts of ponies, but Rainbow Dash's colors are the best!!", 1, 5.0, "Nick" },
                    { 6, "She's sooooo cute and makes me really happy when I'm lonely (: Wish she talked more though...", 2, 4.0, "Alice" },
                    { 7, "Quite an impeccable product indeed, although I do feel compelled to point out minor fabric manufacturing issues in light of corners being potentially cut during production. That being said, Pinkie Pie is a total cutie that never ceases to melt my tender heart~ Hats off to the lovely souls at Hasbro for spreading the love!", 3, 4.5, "Chad" },
                    { 8, "She's sooooo cute and makes me really happy when I'm lonely (: Wish she talked more though...", 4, 3.5, "Mina" },
                    { 9, "I don't even know where to start with Twilight Sparkle. If I could give her more than 5 stars, I would. I deeply connect with her cutie mark which represents the interconnectedness of all. I just got it as a tattoo. TS4L ", 4, 5.0, "Charles" },
                    { 10, "I just have to be the one to say it. Rainbow Dash isn't all she's cracked up to be. I've literally had night terrors where she appears at the end of my bed and her eyes are like black bottomless pits into the darkness of my soul. So scary.", 1, 1.0, "Viktor" },
                    { 11, "Fluttershy is my personal favorite. I love everything about her and though I do not have anything bad to say about Fluttershy I did have a bad experience with one of the toys. Lets just say it required a doctor consultation. So I give it a 1.", 2, 1.0, "Albert" },
                    { 12, "I watch My Little Ponies every single day. I am a very big fan of the show and my favorite pony is Pinkie Pie. She is so kind and shy and it reminds me of myself.", 3, 5.0, "Esmay" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 12);

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
    }
}
