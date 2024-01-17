using Newtonsoft.Json;

namespace EventLink.Models
{
    public class InstagramPostsEvents
    {
        
        public long Id { get; set; }

        
        public string? Caption { get; set; }

        
        public Uri DisplayUrl { get; set; }

        
        public string OwnerFullName { get; set; }

        
        public string OwnerUsername { get; set; }


        public Uri? Url { get; set; }

        public string Category { get; set; }

    }
}
