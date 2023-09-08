namespace MyBlog.Core.Entities
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string ContentSummary { get; set; }
        public string ContentMain { get; set; }
        public string? Picture { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ViewCount { get; set; }
        private DateTime _publishDate = DateTime.Now;
        public DateTime PublishDate { get => _publishDate; set => _publishDate = value; }
        public ICollection<Comment> Comments { get; set; }
    }
}
