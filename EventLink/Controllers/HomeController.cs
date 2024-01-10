using EventLink.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

namespace EventLink.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (var context = new InstagramPostsEventsContext())
            {
                List<InstagramPostsEvents> data = context.InstagramPostsEvents.ToList();
                return View(data);
            }
        }

        public IActionResult Concerts()
        {
            using (var context = new InstagramPostsEventsConcertsContext())
            {
                List<InstagramPostsEventsConcerts> data = context.InstagramPostsEventsConcerts.ToList();
                return View("Index", data);
            }
        }

        public IActionResult Sports()
        {
            using (var context = new InstagramPostsEventsSportsContext())
            {
                List<InstagramPostsEventsSports> data = context.InstagramPostsEventsSports.ToList();
                return View("Index", data);
            }
        }

        public IActionResult Restaurants()
        {
            using (var context = new InstagramPostsEventsRestaurantsContext())
            {
                List<InstagramPostsEventsRestaurants> data = context.InstagramPostsEventsRestaurants.ToList();
                return View("Index", data);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}