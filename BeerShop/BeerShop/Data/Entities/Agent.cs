using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BeerShop.Data.Entities
{
    public class Agent
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        [Required]
        public string UserId { get; set; } = null!;
        public IdentityUser User { get; init; } = null!;
    }
}
