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
        public ViewResult Create(int id)
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
            return RedirectToAction("Index", "Product");
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

            return RedirectToAction("Detail", "Product", new { id = review.ProductId });
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            Review model = reviewRepo.GetById(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {
            reviewRepo.Delete(review);

            return RedirectToAction("Detail", "Product", new { id = review.ProductId });
        }
    }
}