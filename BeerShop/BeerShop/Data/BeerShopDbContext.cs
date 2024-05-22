using BeerShop.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeerShop.Data
{
    public class BeerShopDbContext : IdentityDbContext
    {
        public BeerShopDbContext(DbContextOptions<BeerShopDbContext> options)
            : base(options)
        {

        }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<BeerType> BeerTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
