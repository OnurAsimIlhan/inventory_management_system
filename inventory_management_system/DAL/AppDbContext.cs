using inventory_management_system.Models;
using Microsoft.EntityFrameworkCore;

namespace inventory_management_system.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }       

        public virtual DbSet<Product> Products { get; set; }    
    }
}
