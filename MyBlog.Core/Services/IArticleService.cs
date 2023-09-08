using MyBlog.Core.Entities;
using MyBlog.Dtos.Dtos.ArticleDtos;

namespace MyBlog.Core.Services
{
    public interface IArticleService : IService<Article, ArticleDto, CreateArticleDto, UpdateArticleDto, ListArticleDto>
    {
    }
}
