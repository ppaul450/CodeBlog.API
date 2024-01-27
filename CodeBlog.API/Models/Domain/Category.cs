namespace CodeBlog.API.Models.Domain
{
    public class Category
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string UrlPath { get; set; }
    }
}
