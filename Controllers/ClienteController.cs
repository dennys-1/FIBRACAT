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
<<<<<<< HEAD
    public class ClienteController:Controller
=======
    public class ClienteController : Controller
>>>>>>> 4aa101fe4a28c99452f8745bbeaa22d2a74e9354
    {
        public IActionResult Inicio()
        {
            return View();
        }
    }
}