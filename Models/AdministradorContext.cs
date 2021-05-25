using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIBRACAT.Models
{
    public class AdministradorContext:DbContext
    {
        public AdministradorContext(DbContextOptions<AdministradorContext> options):base(options)
        {
        }

        public DbSet<Administrador> Solicitudes { get; set; }
       
       
         
    }
}
