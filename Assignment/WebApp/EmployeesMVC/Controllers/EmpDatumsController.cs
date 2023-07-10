using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeesMVC.Models;

namespace EmployeesMVC.Controllers
{
    public class EmpDatumsController : Controller
    {
        private readonly EmployeesMvcEntityFwContext _context;

        public EmpDatumsController(EmployeesMvcEntityFwContext context)
        {
            _context = context;
        }

        // GET: EmpDatums
        public async Task<IActionResult> Index()
        {
              return _context.EmpData != null ? 
                          View(await _context.EmpData.ToListAsync()) :
                          Problem("Entity set 'EmployeesMvcEntityFwContext.EmpData'  is null.");
        }

        // GET: EmpDatums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EmpData == null)
            {
                return NotFound();
            }

            var empDatum = await _context.EmpData
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (empDatum == null)
            {
                return NotFound();
            }

            return View(empDatum);
        }

        // GET: EmpDatums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmpDatums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,EmployeeName,EmployeeCity,EmployeeDob,EmployeeGender,EmployeeSalary")] EmpDatum empDatum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empDatum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empDatum);
        }

        // GET: EmpDatums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EmpData == null)
            {
                return NotFound();
            }

            var empDatum = await _context.EmpData.FindAsync(id);
            if (empDatum == null)
            {
                return NotFound();
            }
            return View(empDatum);
        }

        // POST: EmpDatums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,EmployeeName,EmployeeCity,EmployeeDob,EmployeeGender,EmployeeSalary")] EmpDatum empDatum)
        {
            if (id != empDatum.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empDatum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpDatumExists(empDatum.EmployeeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(empDatum);
        }

        // GET: EmpDatums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EmpData == null)
            {
                return NotFound();
            }

            var empDatum = await _context.EmpData
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (empDatum == null)
            {
                return NotFound();
            }

            return View(empDatum);
        }

        // POST: EmpDatums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EmpData == null)
            {
                return Problem("Entity set 'EmployeesMvcEntityFwContext.EmpData'  is null.");
            }
            var empDatum = await _context.EmpData.FindAsync(id);
            if (empDatum != null)
            {
                _context.EmpData.Remove(empDatum);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpDatumExists(int id)
        {
          return (_context.EmpData?.Any(e => e.EmployeeId == id)).GetValueOrDefault();
        }
    }
}
