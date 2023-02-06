using FoodPrepers.Server.Data;
using FoodPrepers.Server.IRepository;
using FoodPrepers.Server.Models;
using FoodPrepers.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FoodPrepers.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Food> _Foods;
        private IGenericRepository<MealFood> _MealFoods;
        private IGenericRepository<MealPlan> _MealPlans;
        private IGenericRepository<Meal> _Meals;
        private IGenericRepository<NutritionFact> _NutritionFacts;
        private IGenericRepository<Staff> _Staffs;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Food> Foods
            => _Foods ??= new GenericRepository<Food>(_context);
        public IGenericRepository<MealFood> MealFoods
            => _MealFoods ??= new GenericRepository<MealFood>(_context);
        public IGenericRepository<MealPlan> MealPlans
            => _MealPlans ??= new GenericRepository<MealPlan>(_context);
        public IGenericRepository<Staff> Staffs
            => _Staffs ??= new GenericRepository<Staff>(_context);
        public IGenericRepository<Meal> Meals
            => _Meals ??= new GenericRepository<Meal>(_context);
        public IGenericRepository<NutritionFact> NutritionFacts
            => _NutritionFacts ??= new GenericRepository<NutritionFact>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}