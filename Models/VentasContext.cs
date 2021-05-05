using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreMVCCRUD.Models
{
    public class VentasContext:DbContext
    {
         public VentasContext(DbContextOptions<VentasContext> options):base(options)
        {
        }

        public DbSet<Administrador> Admin { get; set; }
         public DbSet<Ventas> VENTA { get; set; }
        
    }
}