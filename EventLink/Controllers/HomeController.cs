using EventLink.Models;
using Microsoft.AspNetCore.Mvc;
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
        private InstagramPostsContext context { get; set; }

        public HomeController(InstagramPostsContext ctx)
        {
            context = ctx;
        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public async Task<InstagramPosts> GetJsonDataFromApiAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://api.apify.com/v2/actor-tasks/exclusive_commode~eventlink---instagram-post-scraper/run-sync-get-dataset-items?token=apify_api_Uea6k2FqNtwergHaVTQ5YiVQm2Q4d80BNqpH");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    InstagramPosts data = JsonConvert.DeserializeObject<InstagramPosts>(json);
                    return data;
                }
                else
                {
                    // Handle the error response
                    throw new HttpRequestException($"API request failed with status code {response.StatusCode}");
                }
            }
        }
        //public async Task InsertDataIntoDatabaseAsync(List<InstagramPosts> data)
        //{
        //    using (var context = new YourDbContext())
        //    {
        //        context.YourModels.AddRange(data);
        //        await context.SaveChangesAsync();
        //    }
        //}
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