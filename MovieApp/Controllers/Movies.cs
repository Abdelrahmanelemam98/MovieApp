using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class Movies : Controller
    {
        private readonly MovieDbContext _context;
        public Movies(MovieDbContext context)
        {
           _context=context;
        }
        public async Task< IActionResult> Index()
        {
            var Movies = await _context.Movies.ToListAsync();
            return View(Movies);
        }
    }
}
