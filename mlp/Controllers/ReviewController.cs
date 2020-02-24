using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mlp.Repositories;
using mlp.Models;

namespace mlp.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }
        // GET: /<controller>/
        public ViewResult Index()
        {
            // Set to model
            var model = reviewRepo.GetAll();

            // Pass model to view
            return View(model);
        }

        public ViewResult Detail(int id)
        {
            var model = reviewRepo.GetById(id);

            return View(model);
        }
    }
}