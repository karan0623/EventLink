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


        // Add this method to your InstagramPostsEvents class
        public string GetCategoryName()
        {
            if (this is InstagramPostsEventsConcerts)
            {
                return "Concerts";
            }
            else if (this is InstagramPostsEventsSports)
            {
                return "Sports";
            }
            else if (this is InstagramPostsEventsRestaurants)
            {
                return "Restaurants";
            }
            else
            {
                return "All";
            }
        }



    }

    public class InstagramPostsEventsConcerts: InstagramPostsEvents
    {

    }

    public class InstagramPostsEventsSports : InstagramPostsEvents
    {

    }

    public class InstagramPostsEventsRestaurants : InstagramPostsEvents
    {

    }
}
