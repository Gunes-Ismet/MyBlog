using AutoMapper;
using FluentValidation;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;
using MyBlog.Core.UnitOfWork;
using MyBlog.Dtos.Dtos.ArticleDtos;

namespace MyBlog.Service.Services
{
    public class ArticleService : Service<Article, ArticleDto, CreateArticleDto, UpdateArticleDto, ListArticleDto>, IArticleService
    {
        public ArticleService(IRepository<Article> repository, IMapper mapper, IUow uow, IValidator<CreateArticleDto> createValidator, IValidator<UpdateArticleDto> updateValidator) : base(repository, mapper, uow, createValidator, updateValidator)
        {
        }
    }
}
