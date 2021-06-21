using Microsoft.EntityFrameworkCore;

namespace RepasoFinal.Models
{
    public class BuscoContext : DbContext
    {
        public DbSet<Producto> TProductos { get; set; }
        public DbSet<Categoria> TCategoria { get; set; }

        public BuscoContext(DbContextOptions dco) : base(dco){
            
        }
    }
}