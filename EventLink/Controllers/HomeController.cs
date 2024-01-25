using EventLink.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Linq;

namespace EventLink.Controllers
{
    //Parts of this code ChatGPT was used in order to help with the functionality
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

      public IActionResult Index(string category = "All")
        {
            using (var context = new InstagramPostsEventsContext())
            {
                IQueryable<InstagramPostsEvents> query = context.InstagramPostsEvents;

                if (category != "All")
                {
                    query = query.Where(e => e.Category == category);
                }

                List<InstagramPostsEvents> data = query.ToList();
                return View(data);
            }
        }

        public static string GetRandomImageFromFolder(string categoryCode)
        {
            string imageFolderSubPath;

            if (categoryCode.ToLower() == "r")
            {
                imageFolderSubPath = "restaurants";
            }
            else if (categoryCode.ToLower() == "s")
            {
                imageFolderSubPath = "sports";
            }
            else if (categoryCode.ToLower() == "c")
            {
                imageFolderSubPath = "concerts";
            }
            else
            {
                imageFolderSubPath = "default"; // default folder for unrecognized categories
            }

            var baseImageFolder = Path.Combine("wwwroot", "images", imageFolderSubPath);
            var images = Directory.GetFiles(baseImageFolder, "*.jpg"); // Adjust for different image formats if needed

            if (images.Length == 0)
            {
                return "/images/default/default-image.jpg"; // Path to a default image if no images are found
            }

            Random rand = new Random();
            var randomImage = images[rand.Next(images.Length)];
            var relativePath = Path.Combine("/images", imageFolderSubPath, Path.GetFileName(randomImage));

            return relativePath.Replace('\\', '/'); // Convert to web-friendly path
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
