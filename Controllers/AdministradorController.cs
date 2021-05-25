using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using FIBRACAT.Models;

namespace FIBRACAT.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly AdministradorContext _context;

        public AdministradorController(AdministradorContext context)
        {
            _context = context;
        }

        // GET: Administrador
        public async Task<IActionResult> Index()
        {
            return View(await _context.Solicitudes.ToListAsync());
        }


        // GET: Administrador/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Administrador());
            else
                return View(_context.Solicitudes.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("CID,NPRODUCTO,FOTO,DESCRIPCION,PRECIO,CELULAR,LUGAR,NCOMPRADOR,CATEGORIA")] Administrador administrador)
        {
            if (ModelState.IsValid)
            {
                if (administrador.CID == 0)
                    _context.Add(administrador);
                else
                    _context.Update(administrador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(administrador);
        }


        // GET: Administrador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var administrador =await _context.Solicitudes.FindAsync(id);
            _context.Solicitudes.Remove(administrador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
