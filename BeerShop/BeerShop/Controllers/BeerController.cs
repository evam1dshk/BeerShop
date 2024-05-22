using BeerShop.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using BeerShop.Data;
using Microsoft.EntityFrameworkCore;

namespace BeerShop.Controllers
{
    public class BeerController : Controller
    {
        private readonly BeerShopDbContext _context;

        public BeerController(BeerShopDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var beers = _context.Beers.Include(b => b.BeerType).ToList();
            return View(beers);
        }

        public IActionResult Details(int id)
        {
            var beer = _context.Beers.Include(b => b.BeerType).FirstOrDefault(b => b.Id == id);
            if (beer == null)
            {
                return NotFound();
            }
            return View(beer);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.BeerTypes, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Beer beer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(beer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = new SelectList(_context.BeerTypes, "Id", "Name", beer.BeerTypeId);
            return View(beer);
        }

    }
}
