using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.Services;
using MyBlog.Dtos.Dtos.ArticleDtos;

namespace MyBlog.API.Controllers
{
    public class ArticlesController : CustomBaseController
    {
        private readonly IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllArticle()
        {
            return ActionResultInstance(await _articleService.GetAllAsync());
        }
        [HttpPost]
        public async Task<IActionResult> CreateArticle(CreateArticleDto model)
        {
            return ActionResultInstance(await _articleService.CreateAsync(model));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateArticle(UpdateArticleDto model)
        {
            return ActionResultInstance(await _articleService.UpdateAsync(model));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveArticle(int id)
        {
            return ActionResultInstance(await _articleService.RemoveAsync(id));
        }
    }
}
