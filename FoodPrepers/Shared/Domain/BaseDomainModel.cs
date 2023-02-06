using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPrepers.Shared.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }

    public class Food : BaseDomainModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int ServingSize { get; set; }

        public virtual NutritionFact NutritionFacts { get; set; }
    }

    public class NutritionFact : BaseDomainModel
    {
        public int FoodId { get; set; }
        public int ServingSize { get; set; }
        public int CaloricValue { get; set; }
        public int TotalFat { get; set; }
        public int SaturatedFat { get; set; }
        public int TransFat { get; set; }
        public int Cholesterol { get; set; }
        public int Sodium { get; set; }
        public int TotalCarbohydrates { get; set; }
        public int DietaryFiber { get; set; }
        public int Sugars { get; set; }
        public int Protein { get; set; }

        public virtual Food Food { get; set; }
    }

    public class MealPlan : BaseDomainModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalCaloricIntake { get; set; }
        public int TotalProtein { get; set; }
        public int TotalCarbohydrates { get; set; }
        public int TotalFat { get; set; }
        public int TotalSodium { get; set; }
        public int TotalFiber { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }
    }

    public class Meal : BaseDomainModel
    {
        public int MealPlanId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalCaloricIntake { get; set; }
        public int TotalProtein { get; set; }
        public int TotalCarbohydrates { get; set; }
        public int TotalFat { get; set; }
        public int TotalSodium { get; set; }
        public int TotalFiber { get; set; }

        public virtual MealPlan MealPlan { get; set; }
        public virtual ICollection<MealFood> MealFoods { get; set; }
    }

    public class MealFood : BaseDomainModel
    {
        public int MealId { get; set; }
        public int FoodId { get; set; }
        public int ServingSize { get; set; }
        public int TotalCaloricIntake { get; set; }
        public int TotalProtein { get; set; }
        public int TotalFiber { get; set; }

    }
    public class Staff : BaseDomainModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
        public virtual ICollection<NutritionFact> NutritionFacts { get; set; }
    }

}
