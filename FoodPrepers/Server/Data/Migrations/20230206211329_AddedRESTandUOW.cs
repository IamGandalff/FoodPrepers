using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodPrepers.Server.Data.Migrations
{
    public partial class AddedRESTandUOW : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 13, 29, 243, DateTimeKind.Local).AddTicks(2403), new DateTime(2023, 2, 7, 5, 13, 29, 244, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 13, 29, 244, DateTimeKind.Local).AddTicks(1235), new DateTime(2023, 2, 7, 5, 13, 29, 244, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 13, 29, 244, DateTimeKind.Local).AddTicks(1240), new DateTime(2023, 2, 7, 5, 13, 29, 244, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 13, 29, 244, DateTimeKind.Local).AddTicks(1243), new DateTime(2023, 2, 7, 5, 13, 29, 244, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 13, 29, 244, DateTimeKind.Local).AddTicks(1245), new DateTime(2023, 2, 7, 5, 13, 29, 244, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 13, 29, 246, DateTimeKind.Local).AddTicks(1664), new DateTime(2023, 2, 7, 5, 13, 29, 246, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 5, 13, 29, 246, DateTimeKind.Local).AddTicks(1678), new DateTime(2023, 2, 7, 5, 13, 29, 246, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 5, 13, 29, 246, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 5, 13, 29, 246, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 5, 13, 29, 246, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "Password", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@example.com", "John Doe", "secret", null, "johndoe" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janedoe@example.com", "Jane Doe", "secret", null, "janedoe" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
