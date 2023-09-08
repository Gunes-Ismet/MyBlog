using FluentValidation;
using MyBlog.Dtos.Dtos.CategoryDtos;

namespace MyBlog.Service.ValidationRules.CategoryValidators
{
    public class CreateCategoryDtoValidator : AbstractValidator<CreateCategoryDto>
    {
        public CreateCategoryDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Kategori İsmi Boş Geçilemez!").MaximumLength(100).WithMessage("Kategori İsmi 100 Karakterden Uzun Olamaz!");
        }
    }
}
