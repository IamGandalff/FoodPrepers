using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodPrepers.Server.Data;
using FoodPrepers.Shared.Domain;
using FoodPrepers.Server.IRepository;

namespace FoodPrepers.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        

        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        
        //public MealsController(ApplicationDbContext context)
        public MealsController(IUnitOfWork unitOfWork)
        {
           
            // context = context
             _unitOfWork = unitOfWork;

        }

        // GET: api/Meals
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Meal>>> GetMeals()
        public async Task<IActionResult> GetMeals()
        {
         
            //return await _context.Makes.ToListAsync();
            var Meals = await _unitOfWork.Meals.GetAll();
            return Ok(Meals);
        }

        // GET: api/Meals/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Meal>> GetMeal(int id)
        public async Task<IActionResult> GetMeal(int id)
        {
            //var Meal = await _context.Meals.FindAsync(id);
            var Meal = await _unitOfWork.Meals.Get(q => q.Id == id);

            if (Meal == null)
            {
                return NotFound();
            }

            return Ok(Meal);
        }

        // PUT: api/Meals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeal(int id, Meal Meal)
        {
            if (id != Meal.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Meal).State = EntityState.Modified;
            _unitOfWork.Meals.Update(Meal);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MealExists(id))
                if (!await MealExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Meals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Meal>> PostMeal(Meal Meal)
        {
            //_context.Meals.Add(Meal);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Meals.Insert(Meal);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMeal", new { id = Meal.Id }, Meal);
        }

        // DELETE: api/Meals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeal(int id)
        {
            //var Meal = await _context.Meals.FindAsync(id);
            var Meal = await _unitOfWork.Meals.Get(q => q.Id == id);
            if (Meal == null)
            {
                return NotFound();
            }

            //_context.Meals.Remove(Meal);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Meals.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool MealExists(int id)
        private async Task<bool> MealExists(int id)
        {
            //return _context.Meals.Any(e => e.Id == id);
            var Meal = await _unitOfWork.Meals.Get(q => q.Id == id);
            return Meal != null;
        }
    }
}
