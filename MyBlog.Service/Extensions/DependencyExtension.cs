using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Core;
using MyBlog.Core.Repositories;
using MyBlog.Core.Services;
using MyBlog.Core.UnitOfWork;
using MyBlog.Data.Context;
using MyBlog.Data.Repositories;
using MyBlog.Data.UnitOfWork;
using MyBlog.Dtos;
using MyBlog.Dtos.Dtos;
using MyBlog.Service.Services;
using Mapper = MyBlog.Service.AutoMapper.Mapper;

namespace MyBlog.Service.Extensions
{
    public static class DependencyExtension
    {
        public static void AddBusinessDependencies(this IServiceCollection services, Action<ConnectionInformation> connectionString)
        {
            #region DbContext

            var con = new ConnectionInformation();
            connectionString(con);
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(con.ConnectionString);
            });

            #endregion

            #region FluentValidation

            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());

            #endregion

            #region AutoMapper

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Mapper());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            #endregion                    

            #region Services

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<,,,,>), typeof(Service<,,,,>));
            services.AddScoped<IUow, Uow>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICommentService, CommentService>();

            #endregion

            #region Custom Validation Response

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = context =>
                {
                    var errors = context.ModelState.Values.Where(x => x.Errors.Count > 0).SelectMany(x => x.Errors).Select(x => x.ErrorMessage);
                    ErrorDto errorDTO = new ErrorDto(errors.ToList(), true);
                    var response = Response<NoContentResult>.Fail(errorDTO, 400);
                    return new BadRequestObjectResult(response);
                };
            });
            #endregion

        }
    }
}
