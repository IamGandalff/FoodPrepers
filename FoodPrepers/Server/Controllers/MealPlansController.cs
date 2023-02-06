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
    public class MealPlansController : ControllerBase
    {
        

        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        
        //public MealPlansController(ApplicationDbContext context)
        public MealPlansController(IUnitOfWork unitOfWork)
        {
           
            // context = context
             _unitOfWork = unitOfWork;

        }

        // GET: api/MealPlans
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<MealPlan>>> GetMealPlans()
        public async Task<IActionResult> GetMealPlans()
        {
         
            //return await _context.Makes.ToListAsync();
            var MealPlans = await _unitOfWork.MealPlans.GetAll();
            return Ok(MealPlans);
        }

        // GET: api/MealPlans/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<MealPlan>> GetMealPlan(int id)
        public async Task<IActionResult> GetMealPlan(int id)
        {
            //var MealPlan = await _context.MealPlans.FindAsync(id);
            var MealPlan = await _unitOfWork.MealPlans.Get(q => q.Id == id);

            if (MealPlan == null)
            {
                return NotFound();
            }

            return Ok(MealPlan);
        }

        // PUT: api/MealPlans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMealPlan(int id, MealPlan MealPlan)
        {
            if (id != MealPlan.Id)
            {
                return BadRequest();
            }

            //_context.Entry(MealPlan).State = EntityState.Modified;
            _unitOfWork.MealPlans.Update(MealPlan);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!MealPlanExists(id))
                if (!await MealPlanExists(id))
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

        // POST: api/MealPlans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MealPlan>> PostMealPlan(MealPlan MealPlan)
        {
            //_context.MealPlans.Add(MealPlan);
            //await _context.SaveChangesAsync();
            await _unitOfWork.MealPlans.Insert(MealPlan);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMealPlan", new { id = MealPlan.Id }, MealPlan);
        }

        // DELETE: api/MealPlans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMealPlan(int id)
        {
            //var MealPlan = await _context.MealPlans.FindAsync(id);
            var MealPlan = await _unitOfWork.MealPlans.Get(q => q.Id == id);
            if (MealPlan == null)
            {
                return NotFound();
            }

            //_context.MealPlans.Remove(MealPlan);
            //await _context.SaveChangesAsync();
            await _unitOfWork.MealPlans.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool MealPlanExists(int id)
        private async Task<bool> MealPlanExists(int id)
        {
            //return _context.MealPlans.Any(e => e.Id == id);
            var MealPlan = await _unitOfWork.MealPlans.Get(q => q.Id == id);
            return MealPlan != null;
        }
    }
}
