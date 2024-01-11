// InstagramPostUtility.cs
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using EventLink.Models;

namespace EventLink.Models
{


    public static class InstagramPostUtility
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private static readonly string imagesDirectory = "wwwroot/images/concerts";

        public static async Task CheckAndReplaceBrokenUrls(List<InstagramPostsEvents> posts)
        {
            var imageFiles = GetImageFiles();
            foreach (var post in posts)
            {
                if (!await IsUrlAccessible(post.DisplayUrl))
                {
                    string randomImageUrl = GetRandomImageUrl(imageFiles);
                    post.DisplayUrl = new Uri(randomImageUrl, UriKind.Relative); // Use UriKind.Relative
                }
            }

        }

        private static async Task<bool> IsUrlAccessible(Uri url)
        {
            try
            {
                var response = await httpClient.GetAsync(url);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        private static List<string> GetImageFiles()
        {
            return new List<string>(Directory.GetFiles(imagesDirectory, "*.jpg")); // Add other image formats if needed
        }

        private static string GetRandomImageUrl(List<string> imageFiles)
        {
            Random random = new Random();
            int index = random.Next(imageFiles.Count);
            string fileName = Path.GetFileName(imageFiles[index]);

            // Return a relative URL path
            return $"/images/concerts/{fileName}";
        }

    }

}
