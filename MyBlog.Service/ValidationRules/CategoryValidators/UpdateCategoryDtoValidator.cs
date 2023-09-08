using FluentValidation;
using MyBlog.Dtos.Dtos.CategoryDtos;

namespace MyBlog.Service.ValidationRules.CategoryValidators
{
    public class UpdateCategoryDtoValidator : AbstractValidator<UpdateCategoryDto>
    {
        public UpdateCategoryDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Kategori İsmi Boş Geçilemez!").MaximumLength(100).WithMessage("Kategori İsmi 100 Karakterden Uzun Olamaz!");
        }
    }
}
