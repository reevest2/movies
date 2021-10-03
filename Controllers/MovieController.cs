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
        [HttpGet("AddReview")]
        public IActionResult AddReview()
        {
            return View();
        }

        [HttpPost("AddReview")]
        public async Task<IActionResult> AddReviewPost(MovieCreateRequest request)
        {
            await _movieClient.Create(request);
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{id}")]
        public async Task<IActionResult> Edit(string id)
        {
            var movie = await _movieClient.Get(id);
            return View(movie);
        }

        [HttpPost("edit")]
        public async Task<IActionResult> EditPost(Movie movie)
        {
            var request = new MovieEditRequest
            {
                Name = movie.Name,
                Score = movie.Score,
                Review = movie.Review,
                MustWatch = movie.MustWatch
            };

            movie = await _movieClient.Update(movie.Id, request);
            return RedirectToAction("Index");
        }
        [HttpGet("delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _movieClient.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
