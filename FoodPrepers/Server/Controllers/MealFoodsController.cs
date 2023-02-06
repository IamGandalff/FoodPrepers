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
    public class MealFoodsController : ControllerBase
    {
        

        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        
        //public MealFoodsController(ApplicationDbContext context)
        public MealFoodsController(IUnitOfWork unitOfWork)
        {
           
            // context = context
             _unitOfWork = unitOfWork;

        }

        // GET: api/MealFoods
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<MealFood>>> GetMealFoods()
        public async Task<IActionResult> GetMealFoods()
        {
         
            //return await _context.Makes.ToListAsync();
            var MealFoods = await _unitOfWork.MealFoods.GetAll();
            return Ok(MealFoods);
        }

        // GET: api/MealFoods/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<MealFood>> GetMealFood(int id)
        public async Task<IActionResult> GetMealFood(int id)
        {
            //var MealFood = await _context.MealFoods.FindAsync(id);
            var MealFood = await _unitOfWork.MealFoods.Get(q => q.Id == id);

            if (MealFood == null)
            {
                return NotFound();
            }

            return Ok(MealFood);
        }

        // PUT: api/MealFoods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMealFood(int id, MealFood MealFood)
        {
            if (id != MealFood.Id)
            {
                return BadRequest();
            }

            //_context.Entry(MealFood).State = EntityState.Modified;
            _unitOfWork.MealFoods.Update(MealFood);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MealFoodExists(id))
                if (!await MealFoodExists(id))
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

        // POST: api/MealFoods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MealFood>> PostMealFood(MealFood MealFood)
        {
            //_context.MealFoods.Add(MealFood);
            //await _context.SaveChangesAsync();
            await _unitOfWork.MealFoods.Insert(MealFood);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMealFood", new { id = MealFood.Id }, MealFood);
        }

        // DELETE: api/MealFoods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMealFood(int id)
        {
            //var MealFood = await _context.MealFoods.FindAsync(id);
            var MealFood = await _unitOfWork.MealFoods.Get(q => q.Id == id);
            if (MealFood == null)
            {
                return NotFound();
            }

            //_context.MealFoods.Remove(MealFood);
            //await _context.SaveChangesAsync();
            await _unitOfWork.MealFoods.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool MealFoodExists(int id)
        private async Task<bool> MealFoodExists(int id)
        {
            //return _context.MealFoods.Any(e => e.Id == id);
            var MealFood = await _unitOfWork.MealFoods.Get(q => q.Id == id);
            return MealFood != null;
        }
    }
}
