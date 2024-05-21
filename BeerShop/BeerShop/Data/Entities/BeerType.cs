using System.ComponentModel.DataAnnotations;

namespace BeerShop.Data.Entities
{
    public class BeerType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
