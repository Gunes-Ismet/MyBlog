namespace MyBlog.Dtos.Dtos
{
    public class ErrorDto
    {
        public List<String> Errors { get; private set; } = new List<String>();
        public bool IsShow { get; private set; }
        public ErrorDto(string error, bool isShow)
        {
            Errors.Add(error);
            IsShow = isShow;
        }
        public ErrorDto(List<string> error, bool isShow)
        {
            Errors = error;
            IsShow = isShow;
        }
    }
}
