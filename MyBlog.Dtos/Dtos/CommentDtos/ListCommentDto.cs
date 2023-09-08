namespace MyBlog.Dtos.Dtos.CommentDtos
{
    public class ListCommentDto
    {
        public int ArticleId { get; set; }
        public string Name { get; set; }
        public string ContentMain { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
