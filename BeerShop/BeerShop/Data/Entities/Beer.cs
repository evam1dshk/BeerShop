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
        public string BeerName { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string BeerGlass { get; set; }

        [Required]
        public string Producer { get; set; }

        [Required]
        public string CriticScore { get; set; }

        [Required]
        public string AlcoholBV { get; set; }

        [Required]
        public string TestingNotes { get; set; }

        [Required]
        public string Packaging { get; set; }

        [Required]
        public int BeerTypeId { get; set; }

        public BeerType BeerType { get; set; }

        public Guid AgentId { get; set; }
        public Agent Agent { get; init; } = null!;
    }
}
