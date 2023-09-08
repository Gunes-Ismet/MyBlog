namespace MyBlog.Dtos.Dtos.CommentDtos
{
    public class UpdateCommentDto : IDto
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Name { get; set; }
        public string ContentMain { get; set; }
    }
}
