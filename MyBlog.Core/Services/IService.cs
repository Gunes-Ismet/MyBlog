using MyBlog.Core.Entities;
using MyBlog.Dtos;
using MyBlog.Dtos.Dtos;
using System.Linq.Expressions;

namespace MyBlog.Core.Services
{
    public interface IService<T, Dto, CreateDto, UpdateDto, ListDto>
        where T : BaseEntity
        where Dto : class
        where CreateDto : class
        where UpdateDto : class
        where ListDto : class
    {
        Task<Response<Dto>> GetByIdAsync(int id);
        Task<Response<IEnumerable<ListDto>>> GetAllAsync();
        Task<Response<IEnumerable<ListDto>>> Where(Expression<Func<T, bool>> predicate);
        Task<Response<Dto>> CreateAsync(CreateDto dto);
        Task<Response<NoContentDto>> RemoveAsync(int id);
        Task<Response<Dto>> UpdateAsync(UpdateDto dto);
    }
}
