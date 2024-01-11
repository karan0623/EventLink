using EventLink.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

namespace EventLink.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InstagramPostService _instagramPostService; // Add this

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _instagramPostService = new InstagramPostService(); // Initialize the service
        }

        public async Task<IActionResult> Index() // Change this to async Task<IActionResult>
        {
            using (var context = new InstagramPostsEventsContext())
            {
                // Use the service to get processed Instagram posts
                var data = await _instagramPostService.GetProcessedInstagramPostsAsync(context);
                return View(data);
            }
        }

        /*
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

        } */

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