namespace EventLink.Models
{
    public class CombinedViewModel
    {
        public List<InstagramPostsEvents> InstagramData { get; set; }
        public List<FacebookPostsEvents> FacebookData { get; set; }
        public List<TwitterPostsEvents> TwitterData { get; set; }
    }

}
