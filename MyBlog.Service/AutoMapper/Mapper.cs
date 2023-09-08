using AutoMapper;
using MyBlog.Core.Entities;
using MyBlog.Dtos.Dtos.ArticleDtos;
using MyBlog.Dtos.Dtos.CategoryDtos;
using MyBlog.Dtos.Dtos.CommentDtos;

namespace MyBlog.Service.AutoMapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Article, ArticleDto>().ReverseMap();
            CreateMap<Article, CreateArticleDto>().ReverseMap();
            CreateMap<Article, UpdateArticleDto>().ReverseMap();
            CreateMap<Article, ListArticleDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, ListCategoryDto>().ReverseMap();

            CreateMap<Comment, CommentDto>().ReverseMap();
            CreateMap<Comment, CreateCommentDto>().ReverseMap();
            CreateMap<Comment, UpdateCommentDto>().ReverseMap();
            CreateMap<Comment, ListCommentDto>().ReverseMap();
        }
    }
}
