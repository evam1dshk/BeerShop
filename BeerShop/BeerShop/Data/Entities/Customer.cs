using Microsoft.AspNetCore.Identity;

namespace BeerShop.Data.Entities
{
    public class Customer : IdentityUser
    {
        public ICollection<Cart> Cart { get; set; }
    }
}
