using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeWebApi.Models;

namespace EmployeeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly EmployeesMvcEntityFwContext _context;

        public EmpController(EmployeesMvcEntityFwContext context)
        {
            _context = context;
        }

        // GET: api/Emp
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpDatum>>> GetEmpData()
        {
          if (_context.EmpData == null)
          {
              return NotFound();
          }
            return await _context.EmpData.ToListAsync();
        }

        // GET: api/Emp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpDatum>> GetEmpDatum(int id)
        {
          if (_context.EmpData == null)
          {
              return NotFound();
          }
            var empDatum = await _context.EmpData.FindAsync(id);

            if (empDatum == null)
            {
                return NotFound();
            }

            return empDatum;
        }

        // PUT: api/Emp/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpDatum(int id, EmpDatum empDatum)
        {
            if (id != empDatum.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(empDatum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpDatumExists(id))
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

        // POST: api/Emp
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmpDatum>> PostEmpDatum(EmpDatum empDatum)
        {
          if (_context.EmpData == null)
          {
              return Problem("Entity set 'EmployeesMvcEntityFwContext.EmpData'  is null.");
          }
            _context.EmpData.Add(empDatum);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmpDatumExists(empDatum.EmployeeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmpDatum", new { id = empDatum.EmployeeId }, empDatum);
        }

        // DELETE: api/Emp/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpDatum(int id)
        {
            if (_context.EmpData == null)
            {
                return NotFound();
            }
            var empDatum = await _context.EmpData.FindAsync(id);
            if (empDatum == null)
            {
                return NotFound();
            }

            _context.EmpData.Remove(empDatum);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpDatumExists(int id)
        {
            return (_context.EmpData?.Any(e => e.EmployeeId == id)).GetValueOrDefault();
        }
    }
}
