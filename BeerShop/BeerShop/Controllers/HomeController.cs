using BeerShop.Data;
using BeerShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BeerShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly BeerShopDbContext data;

        public HomeController(BeerShopDbContext data)
            => this.data = data;
    }
}