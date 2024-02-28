using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace EventLink.Models
{
    public class FacebookPostsEvents
    {
        [Key]
        public long PostId { get; set; }

        public string PageName { get; set; }

        public Uri Url { get; set; }

        public string? Text { get; set; }

        public string Category { get; set; }

        public string Subcategory { get; set; }


    }
}
