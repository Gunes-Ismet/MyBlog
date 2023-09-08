namespace MyBlog.Core.Entities
{
    public class Comment : BaseEntity
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public string Name { get; set; }
        public string ContentMain { get; set; }
        private DateTime _publishDate = DateTime.Now;
        public DateTime PublishDate { get; private set; }
    }
}
