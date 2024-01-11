// InstagramPostService.cs
using EventLink.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace EventLink.Models
{
    public class InstagramPostService
    {
        public async Task<List<InstagramPostsEvents>> GetProcessedInstagramPostsAsync(InstagramPostsEventsContext context)
        {
            List<InstagramPostsEvents> data = context.InstagramPostsEvents.ToList();
            await InstagramPostUtility.CheckAndReplaceBrokenUrls(data);
            return data;
        }

    }
}
