using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class VentasContext:DbContext
    {
         public VentasContext(DbContextOptions<VentasContext> options):base(options)
        {
        }

          public DbSet<Ventas> Prueba { get; set; }
        
    }
}