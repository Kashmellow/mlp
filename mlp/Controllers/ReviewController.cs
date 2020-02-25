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

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpGet]
        public ViewResult CreateByProductId(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            reviewRepo.Create(review);
            return RedirectToAction("Index");
        }
        
        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();
            
            return View(model);
        }
        public ViewResult Details(int id)
        {
            Review model = reviewRepo.GetById(id);

            return View(model);
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            Review model = reviewRepo.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Review review)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            reviewRepo.Update(review);

            return RedirectToAction("Detail", "Review", new { id = review.ReviewId });
        }
    }
}