using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.Services;
using MyBlog.Dtos.Dtos.CategoryDtos;

namespace MyBlog.API.Controllers
{
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return ActionResultInstance(await _categoryService.GetAllAsync());
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto model)
        {
            return ActionResultInstance(await _categoryService.CreateAsync(model));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto model)
        {
            return ActionResultInstance(await _categoryService.UpdateAsync(model));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCategory(int id)
        {
            return ActionResultInstance(await _categoryService.RemoveAsync(id));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id) 
        { 
            return ActionResultInstance(await _categoryService.GetByIdAsync(id));
        }
    }
}
