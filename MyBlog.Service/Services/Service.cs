using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;
using MyBlog.Core.UnitOfWork;
using MyBlog.Dtos;
using MyBlog.Dtos.Dtos;
using System.Linq.Expressions;

namespace MyBlog.Service.Services
{
    public class Service<T, Dto, CreateDto, UpdateDto, ListDto> : IService<T, Dto, CreateDto, UpdateDto, ListDto>
        where T : BaseEntity
        where Dto : class
        where CreateDto : class
        where UpdateDto : class
        where ListDto : class

    {
        private readonly IRepository<T> _repository;
        private readonly IMapper _mapper;
        private readonly IUow _uow;
        private readonly IValidator<CreateDto> _createValidator;
        private readonly IValidator<UpdateDto> _updateValidator;

        public Service(IRepository<T> repository, IMapper mapper, IUow uow, IValidator<CreateDto> createValidator, IValidator<UpdateDto> updateValidator)
        {
            _repository = repository;
            _mapper = mapper;
            _uow = uow;
            _createValidator = createValidator;
            _updateValidator = updateValidator;
        }

        public async Task<Response<Dto>> CreateAsync(CreateDto dto)
        {
            var result = _createValidator.Validate(dto);
            if (result.IsValid)
            {
                var entity = _mapper.Map<T>(dto);
                await _repository.CreateAsync(entity);
                await _uow.CommitAsync();
                var newDto = _mapper.Map<Dto>(entity);
                return Response<Dto>.Success(newDto, 201);
            }
            return Response<Dto>.Fail("Kurallara Uyunuz!", 400, true);
        }


        public async Task<Response<IEnumerable<ListDto>>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            var dtoList = _mapper.Map<IEnumerable<ListDto>>(entities);
            return Response<IEnumerable<ListDto>>.Success(dtoList, 200);
        }

        public async Task<Response<Dto>> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity is not null)
            {
                return Response<Dto>.Success(_mapper.Map<Dto>(entity), 200);
            }
            return Response<Dto>.Fail($"{id} id data bulunmadı!", 404, true);
        }

        public async Task<Response<NoContentDto>> RemoveAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity is not null)
            {
                _repository.Remove(entity);
                await _uow.CommitAsync();
                return Response<NoContentDto>.Success(200);
            }
            return Response<NoContentDto>.Fail($"{id} id data bulunamadı!", 404, true);
        }

        public async Task<Response<Dto>> UpdateAsync(UpdateDto dto)
        {
            var result = _updateValidator.Validate(dto);
            if (result.IsValid)
            {
                var entity = _mapper.Map<T>(dto);
                _repository.Update(entity);
                await _uow.CommitAsync();
                var newDto = _mapper.Map<Dto>(entity);
                return Response<Dto>.Success(newDto, 200);
            }
            return Response<Dto>.Fail("Kurallara Uyunuz!", 400, true);
        }

        public async Task<Response<IEnumerable<ListDto>>> Where(Expression<Func<T, bool>> predicate)
        {
            var entities = await _repository.Where(predicate).ToListAsync();
            var dtoList = _mapper.Map<IEnumerable<ListDto>>(entities);
            return Response<IEnumerable<ListDto>>.Success(dtoList, 200);
        }
    }
}
