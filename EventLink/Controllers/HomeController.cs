using EventLink.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

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
            using (var webClient = new WebClient())
            {

                string jsonString = webClient.DownloadString("https://api.apify.com/v2/actor-tasks/exclusive_commode~eventlink---instagram-post-scraper/run-sync-get-dataset-items?token=apify_api_Uea6k2FqNtwergHaVTQ5YiVQm2Q4d80BNqpH");
                var post = InstagramPosts.FromJson(jsonString);
                ViewData["Insta"] = post;
            }
            return View();
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