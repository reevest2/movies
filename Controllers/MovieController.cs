using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movies.Models;
using movies.Clients;

namespace movies.Controllers
{
    [Route("movies")]
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
    }
}
