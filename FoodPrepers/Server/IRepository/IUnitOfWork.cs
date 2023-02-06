using FoodPrepers.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodPrepers.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Food> Foods { get; }
        IGenericRepository<MealFood> MealFoods { get; }
        IGenericRepository<MealPlan> MealPlans { get; }
        IGenericRepository<Meal> Meals { get; }
        IGenericRepository<NutritionFact> NutritionFacts { get; }
        IGenericRepository<Staff> Staffs { get; }
    }
}