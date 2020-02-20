using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mlp.Repositories;
using mlp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mlp.Controllers
{
    public class ProductController : Controller
    {
        IRepository<Product> productRepo;

        public ProductController(IRepository<Product> productRepo)
        {
            this.productRepo = productRepo;
        }
        // GET: /<controller>/
        public  ViewResult Index()
        {
            // Create repository
            // ProductRepository productRepo = new ProductRepository();

            // Set to model
            var model = productRepo.GetAll();

            // Pass model to view
            return View(model);
        }

        public ViewResult Detail(int id)
        {
            // ProductRepository productRepo = new ProductRepository();

            var model = productRepo.GetById(id);

            return View(model);
        }
    }

}
