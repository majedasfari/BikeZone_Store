using BikeZone_Store.Data;
using Microsoft.AspNetCore.Mvc;

namespace BikeZone_Store.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ProjectoneDbcontext _context;

        public CategoryController(ProjectoneDbcontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categorias = _context.Categories.ToList();
            return View(categorias);
        }
    }
}