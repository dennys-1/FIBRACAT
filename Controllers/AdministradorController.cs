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
            return View(await _context.Admin.ToListAsync());
        }


        // GET: Administrador/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Administrador());
            else
                return View(_context.Admin.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("CID,CORREO,TELEFONO,DNI,DIRECCION")] Administrador administrador)
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
            var administrador =await _context.Admin.FindAsync(id);
            _context.Admin.Remove(administrador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
