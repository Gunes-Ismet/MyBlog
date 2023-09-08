using MyBlog.Core.Entities;
using MyBlog.Dtos.Dtos.CategoryDtos;

namespace MyBlog.Core.Services
{
    public interface ICategoryService : IService<Category, CategoryDto, CreateCategoryDto, UpdateCategoryDto, ListCategoryDto>
    {
    }
}
