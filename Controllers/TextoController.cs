using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using poiesis_mvc.Context;
using poiesis_mvc.Models;

namespace poiesis_mvc.Controllers
{
    public class TextoController : Controller
    {
        private readonly PoiesisDBContext _context;

        public TextoController(PoiesisDBContext context)
        {
            _context = context;
        }

        // GET: Texto
        public async Task<IActionResult> Index()
        {
            var poiesisDBContext = _context.Textos.Include(t => t.Usuario);
            return View(await poiesisDBContext.ToListAsync());
        }

        // GET: Texto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var texto = await _context.Textos
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.idTexto == id);
            if (texto == null)
            {
                return NotFound();
            }

            return View(texto);
        }

        // GET: Texto/Create
        public IActionResult Create()
        {
            ViewData["idUsuario"] = new SelectList(_context.Usuarios, "idUsuario", "idUsuario");
            return View();
        }

        // POST: Texto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idTexto,idUsuario,fechaPublicacion,titulo,contenido,genero")] Texto texto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(texto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idUsuario"] = new SelectList(_context.Usuarios, "idUsuario", "idUsuario", texto.idUsuario);
            return View(texto);
        }

        // GET: Texto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var texto = await _context.Textos.FindAsync(id);
            if (texto == null)
            {
                return NotFound();
            }
            ViewData["idUsuario"] = new SelectList(_context.Usuarios, "idUsuario", "idUsuario", texto.idUsuario);
            return View(texto);
        }

        // POST: Texto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idTexto,idUsuario,fechaPublicacion,titulo,contenido,genero")] Texto texto)
        {
            if (id != texto.idTexto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(texto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TextoExists(texto.idTexto))
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
            ViewData["idUsuario"] = new SelectList(_context.Usuarios, "idUsuario", "idUsuario", texto.idUsuario);
            return View(texto);
        }

        // GET: Texto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var texto = await _context.Textos
                .Include(t => t.Usuario)
                .FirstOrDefaultAsync(m => m.idTexto == id);
            if (texto == null)
            {
                return NotFound();
            }

            return View(texto);
        }

        // POST: Texto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var texto = await _context.Textos.FindAsync(id);
            _context.Textos.Remove(texto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TextoExists(int id)
        {
            return _context.Textos.Any(e => e.idTexto == id);
        }
    }
}
