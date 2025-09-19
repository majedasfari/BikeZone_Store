using BikeZone_Store.Data;
using BikeZone_Store.Models;
using Microsoft.AspNetCore.Mvc;

namespace BikeZone_Store.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ProjectoneDbcontext _context;


        public ProductsController(ProjectoneDbcontext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try {
                var Products = _context.Products.ToList();
                return View(Products);
            }
            catch (Exception ex)
            {
                return BadRequest("حدث خطء");
            }
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create( Product product)
        {
            try {
                if (!ModelState.IsValid)
                {
                    return View(product);
                }
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return BadRequest("حدث خطء");
            }
        }




        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var product = _context.Products.Find(Id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(product);
                }
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return BadRequest("حدث خطء");
            }
        }


        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var product = _context.Products.Find(Id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            try
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return BadRequest("حدث خطء");
            }
        }



    }
}
