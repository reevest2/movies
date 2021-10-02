using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movies.Models;
using movies.Clients;

namespace movies.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieClient _movieClient;

        public MovieController(MovieClient movieClient)
        {
            _movieClient = movieClient;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await _movieClient.GetAll();
            return View(movies);
        }
        public IActionResult CreateMovie()
        {
            return View();
        }

    }
}
