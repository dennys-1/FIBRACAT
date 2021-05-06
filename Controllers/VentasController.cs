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
    public class VentasController : Controller
    {
        private readonly VentasContext _context;

        public VentasController(VentasContext context)
        {
            _context = context;
        }

        // GET: Administrador
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prueba.ToListAsync());
        }


        // GET: Administrador/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Ventas());
            else
                return View(_context.Prueba.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("IdProducto,Codigo,Nombre,Descripcion,Activo")] Ventas ventas)
        {
            if (ModelState.IsValid)
            {
                if (ventas.IdProducto == 0)
                    _context.Add(ventas);
                else
                    _context.Update(ventas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ventas);
        }


        // GET: Administrador/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var administrador =await _context.Prueba.FindAsync(id);
            _context.Prueba.Remove(ventas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}