using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodPrepers.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Category", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Name", "ServingSize", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Meat", "SeedData", new DateTime(2023, 2, 6, 5, 25, 26, 773, DateTimeKind.Local).AddTicks(887), new DateTime(2023, 2, 6, 5, 25, 26, 773, DateTimeKind.Local).AddTicks(7731), "Lean protein source", "Chicken breast", 100, "SeedData" },
                    { 2, "Fish", "SeedData", new DateTime(2023, 2, 6, 5, 25, 26, 773, DateTimeKind.Local).AddTicks(8287), new DateTime(2023, 2, 6, 5, 25, 26, 773, DateTimeKind.Local).AddTicks(8290), "Omega-3 fatty acid rich food", "Salmon", 100, "SeedData" }
                });

            migrationBuilder.InsertData(
                table: "MealPlans",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Name", "TotalCaloricIntake", "TotalCarbohydrates", "TotalFat", "TotalFiber", "TotalProtein", "TotalSodium", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "SeedData", new DateTime(2023, 2, 6, 5, 25, 26, 775, DateTimeKind.Local).AddTicks(1222), new DateTime(2023, 2, 6, 5, 25, 26, 775, DateTimeKind.Local).AddTicks(1227), "A meal plan high in protein", "High Protein Meal Plan", 2500, 300, 100, 25, 200, 1500, "SeedData", 1 },
                    { 2, "SeedData", new DateTime(2023, 2, 6, 5, 25, 26, 775, DateTimeKind.Local).AddTicks(1231), new DateTime(2023, 2, 6, 5, 25, 26, 775, DateTimeKind.Local).AddTicks(1232), "A meal plan low in carbohydrates", "Low Carb Meal Plan", 2000, 200, 80, 20, 150, 1000, "SeedData", 1 }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "MealPlanId", "Name", "TotalCaloricIntake", "TotalCarbohydrates", "TotalFat", "TotalFiber", "TotalProtein", "TotalSodium", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "SeedData", new DateTime(2023, 2, 6, 5, 25, 26, 775, DateTimeKind.Local).AddTicks(4850), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A meal to start your day", 1, "Breakfast", 500, 50, 20, 10, 25, 200, null },
                    { 2, "SeedData", new DateTime(2023, 2, 6, 5, 25, 26, 775, DateTimeKind.Local).AddTicks(4858), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A meal to have in the middle of your day", 1, "Lunch", 600, 55, 25, 15, 30, 250, null },
                    { 3, "SeedData", new DateTime(2023, 2, 6, 5, 25, 26, 775, DateTimeKind.Local).AddTicks(4860), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A meal to have at the end of your day", 1, "Dinner", 700, 60, 30, 20, 35, 300, null }
                });

            migrationBuilder.InsertData(
                table: "NutritionFacts",
                columns: new[] { "Id", "CaloricValue", "Cholesterol", "CreatedBy", "DateCreated", "DateUpdated", "DietaryFiber", "FoodId", "Protein", "SaturatedFat", "ServingSize", "Sodium", "Sugars", "TotalCarbohydrates", "TotalFat", "TransFat", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 165, 72, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, 31, 1, 100, 74, 0, 0, 3, 0, null },
                    { 2, 208, 55, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 2, 22, 2, 100, 63, 0, 0, 13, 0, null }
                });

            migrationBuilder.InsertData(
                table: "MealFoods",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "FoodId", "MealId", "ServingSize", "TotalCaloricIntake", "TotalFiber", "TotalProtein", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 100, 200, 10, 20, null },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 100, 300, 15, 25, null },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 100, 400, 20, 30, null },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 100, 500, 25, 35, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MealFoods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MealFoods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealFoods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MealFoods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NutritionFacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NutritionFacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
