using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCLearn2k18.Models;

namespace MVCLearn2k18.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }

    }
}