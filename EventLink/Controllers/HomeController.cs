using EventLink.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EventLink.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index() // Change this to async Task<IActionResult>
        {
            using (var context = new InstagramPostsEventsContext())
            {      
                IQueryable<InstagramPostsEvents> query = context.InstagramPostsEvents;
                List<InstagramPostsEvents> data = query.ToList();
                return View(data);
            }
        }

        public static string GetRandomImageFromFolder()
        {
            var imageFolder = "wwwroot/images/concerts"; // image folder
            var images = Directory.GetFiles(imageFolder, "*.jpg"); // retrieving all jpg images
            Random rand = new Random();
            var randomImage = images[rand.Next(images.Length)];
            return "/images/concerts/" + Path.GetFileName(randomImage); // Adjust the path as necessary
        } //Source ChatGPT RandomImageFromFolder() generation method https://chat.openai.com/



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