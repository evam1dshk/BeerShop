using Microsoft.AspNetCore.Identity;

namespace BeerShop.Data.Entities
{
    public class Customer : IdentityUser
    {
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();
    }
}
