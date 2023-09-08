namespace MyBlog.Dtos.Dtos.ArticleDtos
{
    public class CreateArticleDto : IDto
    {
        public string Title { get; set; }
        public string ContentSummary { get; set; }
        public string ContentMain { get; set; }
        public string? Picture { get; set; }
        public int CategoryId { get; set; }
    }
}
