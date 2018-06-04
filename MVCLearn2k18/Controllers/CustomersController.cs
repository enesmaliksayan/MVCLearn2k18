using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLearn2k18.Models;
using MVCLearn2k18.ViewModels;

namespace MVCLearn2k18.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> customers = new List<Customer>
        {
                new Customer() { Name = "John Smitt", Id=1 },
                new Customer() { Name = "Mary Jane", Id=2 }
        };



        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Detail(int id)
        {
            foreach (var c in customers)
            {
                if (c.Id == id)
                {
                    return Content("Hello " + c.Name);
                }
            }
            return HttpNotFound();
        }
    }
}