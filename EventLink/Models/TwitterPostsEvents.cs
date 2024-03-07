namespace EventLink.Models
{
    public class TwitterPostsEvents
    {
        public long Id { get; set; }

        public string? FullText { get; set; }

        public string User { get; set; }

        public Uri? Url { get; set; }
        public string Category { get; set; }

    }

    public class NameData
    {
        public string Name { get; set; }
    }

}
