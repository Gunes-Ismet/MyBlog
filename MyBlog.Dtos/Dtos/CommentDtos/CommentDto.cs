namespace MyBlog.Dtos.Dtos.CommentDtos
{
    public class CommentDto
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Name { get; set; }
        public string ContentMain { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
