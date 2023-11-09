using Newtonsoft.Json;

namespace EventLink.Models
{
    public class InstagramPostsEvents
    {
        
        public string Id { get; set; }

        
        public string Caption { get; set; }

        
        public Uri DisplayUrl { get; set; }

        
        public Uri VideoUrl { get; set; }

        
        public DateTimeOffset? Timestamp { get; set; }

        
        public string OwnerFullName { get; set; }

        
        public string OwnerUsername { get; set; }

        
        public long? OwnerId { get; set; }

        
        public string LocationName { get; set; }

    }
}
