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

    public class ClienteController : Controller

    {
        public IActionResult Inicio()
        {
            return View();
        }
    }
}