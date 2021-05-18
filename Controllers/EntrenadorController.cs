using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreMVCCRUD.Models;


namespace Asp.netCoreMVCCRUD.Controllers
{
    public class EntrenadorController : Controller
    {

          private readonly EntrenadorContext _context;

        public EntrenadorController(EntrenadorContext context)
        {
            _context = context;
        }

        // GET: Administrador
        public async Task<IActionResult> Index()
        {
            return View(await _context.Flores1.ToListAsync());
        }


        // GET: Administrador/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Entrenador());
            else
                return View(_context.Flores1.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Nombre,foto,pueblo")] Entrenador entrenador)
        {
            if (ModelState.IsValid)
            {
                if (entrenador.Id == 0)
                    _context.Add(entrenador);
                else
                    _context.Update(entrenador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entrenador);
        }


        // GET: Administrador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var entrenador =await _context.Flores1.FindAsync(id);
            _context.Flores1.Remove(entrenador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
    }
}