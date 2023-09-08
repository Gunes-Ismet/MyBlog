using MyBlog.Core.Entities;
using MyBlog.Dtos.Dtos.CommentDtos;

namespace MyBlog.Core.Services
{
    public interface ICommentService : IService<Comment, CommentDto, CreateCommentDto, UpdateCommentDto, ListCommentDto>
    {
    }
}
