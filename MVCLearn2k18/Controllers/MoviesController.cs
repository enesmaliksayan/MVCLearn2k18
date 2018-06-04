using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLearn2k18.Models;
using MVCLearn2k18.ViewModels;

namespace MVCLearn2k18.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer() { Name = "Customer 1" },
                new Customer() { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            // return Content("Hello World!");
            // return HttpNotFound();
            // return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {

            var movie = new List<Movie>()
            {
                new Movie() { Name = "Shrek!", Id=1 },
                new Movie() { Name = "Batman", Id=2 }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movie,
            };

            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return View(viewModel);
        }


        // bi alttaki satır ilgili actionresult'ın yolunu veriyor.
        [Route("movies/released/{year:regex(1[8-9]\\d{2}|20[0-1][0-9])}/{month:regex(0[1-9]|10|11|12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}