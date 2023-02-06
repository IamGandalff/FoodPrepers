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
    public class NutritionFactsController : ControllerBase
    {
        

        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        
        //public NutritionFactsController(ApplicationDbContext context)
        public NutritionFactsController(IUnitOfWork unitOfWork)
        {
           
            // context = context
             _unitOfWork = unitOfWork;

        }

        // GET: api/NutritionFacts
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<NutritionFact>>> GetNutritionFacts()
        public async Task<IActionResult> GetNutritionFacts()
        {
         
            //return await _context.Makes.ToListAsync();
            var NutritionFacts = await _unitOfWork.NutritionFacts.GetAll();
            return Ok(NutritionFacts);
        }

        // GET: api/NutritionFacts/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<NutritionFact>> GetNutritionFact(int id)
        public async Task<IActionResult> GetNutritionFact(int id)
        {
            //var NutritionFact = await _context.NutritionFacts.FindAsync(id);
            var NutritionFact = await _unitOfWork.NutritionFacts.Get(q => q.Id == id);

            if (NutritionFact == null)
            {
                return NotFound();
            }

            return Ok(NutritionFact);
        }

        // PUT: api/NutritionFacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNutritionFact(int id, NutritionFact NutritionFact)
        {
            if (id != NutritionFact.Id)
            {
                return BadRequest();
            }

            //_context.Entry(NutritionFact).State = EntityState.Modified;
            _unitOfWork.NutritionFacts.Update(NutritionFact);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!NutritionFactExists(id))
                if (!await NutritionFactExists(id))
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

        // POST: api/NutritionFacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NutritionFact>> PostNutritionFact(NutritionFact NutritionFact)
        {
            //_context.NutritionFacts.Add(NutritionFact);
            //await _context.SaveChangesAsync();
            await _unitOfWork.NutritionFacts.Insert(NutritionFact);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetNutritionFact", new { id = NutritionFact.Id }, NutritionFact);
        }

        // DELETE: api/NutritionFacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNutritionFact(int id)
        {
            //var NutritionFact = await _context.NutritionFacts.FindAsync(id);
            var NutritionFact = await _unitOfWork.NutritionFacts.Get(q => q.Id == id);
            if (NutritionFact == null)
            {
                return NotFound();
            }

            //_context.NutritionFacts.Remove(NutritionFact);
            //await _context.SaveChangesAsync();
            await _unitOfWork.NutritionFacts.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool NutritionFactExists(int id)
        private async Task<bool> NutritionFactExists(int id)
        {
            //return _context.NutritionFacts.Any(e => e.Id == id);
            var NutritionFact = await _unitOfWork.NutritionFacts.Get(q => q.Id == id);
            return NutritionFact != null;
        }
    }
}
