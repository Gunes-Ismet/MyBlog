using AutoMapper;
using FluentValidation;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;
using MyBlog.Core.UnitOfWork;
using MyBlog.Dtos.Dtos.CommentDtos;

namespace MyBlog.Service.Services
{
    public class CommentService : Service<Comment, CommentDto, CreateCommentDto, UpdateCommentDto, ListCommentDto>, ICommentService
    {
        public CommentService(IRepository<Comment> repository, IMapper mapper, IUow uow, IValidator<CreateCommentDto> createValidator, IValidator<UpdateCommentDto> updateValidator) : base(repository, mapper, uow, createValidator, updateValidator)
        {
        }
    }
}
