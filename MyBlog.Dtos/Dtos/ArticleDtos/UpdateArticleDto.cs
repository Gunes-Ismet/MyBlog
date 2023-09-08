namespace MyBlog.Dtos.Dtos.ArticleDtos
{
    public class UpdateArticleDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContentSummary { get; set; }
        public string ContentMain { get; set; }
        public string? Picture { get; set; }
        public int CategoryId { get; set; }
        //public int ViewCount { get; set; }
        //public DateTime PublishDate { get; set; }

    }
}
