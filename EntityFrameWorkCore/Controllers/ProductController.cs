using EntityFrameWorkCore.Entities;
using EntityFrameWorkCore.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWorkCore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository=repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            //var p = repository.Products.Where(i => i.Category == "Product Category 1").FirstOrDefault(i => i.Price > 50);
            return View(repository.Products);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Product product)
        {
            repository.CreateProduct(product);
            return RedirectToAction("List");
        }

        public IActionResult Details(int id)
        {
            return View(repository.GetById(id));
        }
        [HttpPost]
        public IActionResult Details(Product product)
        {
            repository.UpdateProduct(product);
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            repository.DeleteProduct(id);
            return RedirectToAction("List");
        }

    }
}
