using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPrepers.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string FoodsEndpoint = $"{Prefix}/foods";
        public static readonly string MealFoodsEndpoint = $"{Prefix}/mealfoods";
        public static readonly string MealPlansEndpoint = $"{Prefix}/mealplans";
        public static readonly string MealsEndpoint = $"{Prefix}/meals";
        public static readonly string NutritionFactsEndpoint = $"{Prefix}/nutritionfacts";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
    }
}
