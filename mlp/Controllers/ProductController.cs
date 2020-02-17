using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mlp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mlp.Controllers
{
    public class ProductController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            // Create repository
            ProductRepository productRepo = new ProductRepository();
            // Set to model
            var model = productRepo.GetAll();

            // Pass model to view
            return View(model);
        }

        public IActionResult Detail(int id)
        {

            ProductRepository productRepo = new ProductRepository();

            var model = productRepo.GetById(id);

            return View(model);
          
        }
    }

}
