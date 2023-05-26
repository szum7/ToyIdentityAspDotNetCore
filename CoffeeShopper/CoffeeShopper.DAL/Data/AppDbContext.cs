using CoffeeShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
