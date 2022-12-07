using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prueba_Banco.Data;
using Prueba_Banco.Models;

namespace Prueba_Banco.Controllers
{
    public class VentasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VentasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ventas
        public async Task<IActionResult> Index()
        {
              return View(await _context.Ventas.ToListAsync());
        }

        public async Task<IActionResult> Busqueda()
        {
            return View();
        }



        public async Task<IActionResult> MostrarResultados(string parametro)
        {
                    return View("Index", await _context.Ventas.Where(v => v.CODGTE.Contains(parametro)).ToListAsync());
            // return View("Index", await _context.Ventas.Where(v => v.CODCOOR.Contains(parametro)).ToListAsync());
            // return View("Index", await _context.Ventas.Where(v => v.NOM_CLIENTE.Contains(parametro)).ToListAsync());
            // return View("Index", await _context.Ventas.Where(v => v.ITEM.Contains(parametro)).ToListAsync());


        }
        // GET: Ventas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ventas == null)
            {
                return NotFound();
            }


            var ventas = await _context.Ventas
                .FirstOrDefaultAsync(m => m.id == id);
            if (ventas == null)
            {
                return NotFound();
            }

            return View(ventas);
        }

        // GET: Ventas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ventas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,CODGTE,NOMGTE,CODCOOR,NOMCOOR,CODVENTAS,NOMVEND,CODNIVEL,NOMNIVEL,NIT_CLIENTE,ITEM,NOM_CLIENTE,SEGMENTO,GERENCIADO,OFICINA_CLIENTE,FECHAFIL,PERIODOMED,CONDIC,CTACAMP")] Ventas ventas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ventas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ventas);
        }

        // GET: Ventas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ventas == null)
            {
                return NotFound();
            }

            var ventas = await _context.Ventas.FindAsync(id);
            if (ventas == null)
            {
                return NotFound();
            }
            return View(ventas);
        }

        // POST: Ventas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,CODGTE,NOMGTE,CODCOOR,NOMCOOR,CODVENTAS,NOMVEND,CODNIVEL,NOMNIVEL,NIT_CLIENTE,ITEM,NOM_CLIENTE,SEGMENTO,GERENCIADO,OFICINA_CLIENTE,FECHAFIL,PERIODOMED,CONDIC,CTACAMP")] Ventas ventas)
        {
            if (id != ventas.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ventas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VentasExists(ventas.id))
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
            return View(ventas);
        }

        // GET: Ventas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ventas == null)
            {
                return NotFound();
            }

            var ventas = await _context.Ventas
                .FirstOrDefaultAsync(m => m.id == id);
            if (ventas == null)
            {
                return NotFound();
            }

            return View(ventas);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ventas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Ventas'  is null.");
            }
            var ventas = await _context.Ventas.FindAsync(id);
            if (ventas != null)
            {
                _context.Ventas.Remove(ventas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VentasExists(int id)
        {
          return _context.Ventas.Any(e => e.id == id);
        }
    }
}
