using Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_API.DateContext
{
    public class AplicatioonDbContext : DbContext
    {
        public AplicatioonDbContext(DbContextOptions<AplicatioonDbContext> options) : base(options)
        {
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
