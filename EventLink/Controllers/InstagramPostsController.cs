using EventLink.Models;
using Newtonsoft.Json;

namespace EventLink.Controllers
{
    public class InstagramPostsController
    {
        private InstagramPostsContext context { get; set; }
        public InstagramPostsController(InstagramPostsContext ctx)
        {
            context = ctx;

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
        public async Task InsertDataIntoDatabaseAsync(List<InstagramPosts> data)
        {
            using (var context = new InstagramPostsContext(options: null))
            {
                context.InstagramPosts.AddRange(data);
                await context.SaveChangesAsync();
            }
        }
    }
}
