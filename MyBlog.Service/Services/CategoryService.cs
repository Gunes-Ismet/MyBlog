using AutoMapper;
using FluentValidation;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;
using MyBlog.Core.UnitOfWork;
using MyBlog.Dtos.Dtos.CategoryDtos;

namespace MyBlog.Service.Services
{
    public class CategoryService : Service<Category, CategoryDto, CreateCategoryDto, UpdateCategoryDto, ListCategoryDto>, ICategoryService
    {
        public CategoryService(IRepository<Category> repository, IMapper mapper, IUow uow, IValidator<CreateCategoryDto> createValidator, IValidator<UpdateCategoryDto> updateValidator) : base(repository, mapper, uow, createValidator, updateValidator)
        {
        }
    }
}
