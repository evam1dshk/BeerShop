using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerShop.Data.Entities
{
    public class Beer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string BeerName { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string BeerGlass { get; set; } = null!;

        [Required]
        public string Producer { get; set; } = null!;

        [Required]
        public string CriticScore { get; set; }

        [Required]
        public string AlcoholBV { get; set; } = 

        [Required]
        public string TestingNotes { get; set; }

        [Required]
        public string Packaging { get; set; }

        [Required]
        public int BeerTypeId { get; set; }

        public BeerType BeerType { get; set; }
    }
}