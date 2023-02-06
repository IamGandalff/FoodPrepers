using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodPrepers.Server.Data.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 39, 13, 865, DateTimeKind.Local).AddTicks(1619), new DateTime(2023, 2, 7, 2, 39, 13, 865, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 39, 13, 865, DateTimeKind.Local).AddTicks(9347), new DateTime(2023, 2, 7, 2, 39, 13, 865, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 39, 13, 865, DateTimeKind.Local).AddTicks(9352), new DateTime(2023, 2, 7, 2, 39, 13, 865, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 39, 13, 865, DateTimeKind.Local).AddTicks(9355), new DateTime(2023, 2, 7, 2, 39, 13, 865, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 39, 13, 865, DateTimeKind.Local).AddTicks(9357), new DateTime(2023, 2, 7, 2, 39, 13, 865, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 39, 13, 867, DateTimeKind.Local).AddTicks(2571), new DateTime(2023, 2, 7, 2, 39, 13, 867, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 39, 13, 867, DateTimeKind.Local).AddTicks(2580), new DateTime(2023, 2, 7, 2, 39, 13, 867, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 2, 39, 13, 867, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 2, 39, 13, 867, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 2, 39, 13, 867, DateTimeKind.Local).AddTicks(6177));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 8, 14, 138, DateTimeKind.Local).AddTicks(994), new DateTime(2023, 2, 7, 2, 8, 14, 138, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 8, 14, 138, DateTimeKind.Local).AddTicks(8794), new DateTime(2023, 2, 7, 2, 8, 14, 138, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 8, 14, 138, DateTimeKind.Local).AddTicks(8799), new DateTime(2023, 2, 7, 2, 8, 14, 138, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 8, 14, 138, DateTimeKind.Local).AddTicks(8802), new DateTime(2023, 2, 7, 2, 8, 14, 138, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 8, 14, 138, DateTimeKind.Local).AddTicks(8858), new DateTime(2023, 2, 7, 2, 8, 14, 138, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 8, 14, 140, DateTimeKind.Local).AddTicks(2530), new DateTime(2023, 2, 7, 2, 8, 14, 140, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 2, 8, 14, 140, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 2, 7, 2, 8, 14, 140, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 2, 8, 14, 140, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 2, 8, 14, 140, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 2, 8, 14, 140, DateTimeKind.Local).AddTicks(6200));
        }
    }
}
