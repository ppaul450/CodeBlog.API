namespace CodeBlog.API.Models.Domain
{
    public class BlogPost
    {
        public Guid ID{ get; set; }

        public string? Title { get; set;}

        public string? ShortDescription { get; set;}

        public string? Content { get; set; }

        public string? ImageUrl { get; set; }

        public string? UrlHandle { get; set; }

        public DateTime PublishedDate { get; set; }

        public string? Author { get; set; }

        public bool ISVisible { get; set; }



    }
}
