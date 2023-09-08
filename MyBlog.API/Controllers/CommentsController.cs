using Microsoft.AspNetCore.Mvc;
using MyBlog.Core.Services;
using MyBlog.Dtos.Dtos.CommentDtos;

namespace MyBlog.API.Controllers
{
    public class CommentsController : CustomBaseController
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllComment()
        {
            return ActionResultInstance(await _commentService.GetAllAsync());
        }
        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentDto model)
        {
            return ActionResultInstance(await _commentService.CreateAsync(model));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateComment(UpdateCommentDto model)
        {
            return ActionResultInstance(await _commentService.UpdateAsync(model));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveComment(int id)
        {
            return ActionResultInstance(await _commentService.RemoveAsync(id));
        }
    }
}
