using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class AdministradorContext:DbContext
    {
        public AdministradorContext(DbContextOptions<AdministradorContext> options):base(options)
        {
        }

        public DbSet<Administrador> Admin { get; set; }
         public DbSet<Ventas> Prueba { get; set; }
         
    }
}
