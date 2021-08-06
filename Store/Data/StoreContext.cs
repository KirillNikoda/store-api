using Microsoft.EntityFrameworkCore;
using Store.Entities;

namespace Store.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            
        }
        
        public DbSet<Product> Products { get; set; }
    }
}