using BeerShop.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BeerShop.Data
{
    public class BeerShopDbContext : IdentityDbContext
    {
        public BeerShopDbContext(DbContextOptions<BeerShopDbContext> options)
            : base(options)
        {

        }
        public DbSet<Beer> Beers { get; set; } = null!; 
        public DbSet<BeerType> BeerTypes { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Cart> Carts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

        }
    }
}
