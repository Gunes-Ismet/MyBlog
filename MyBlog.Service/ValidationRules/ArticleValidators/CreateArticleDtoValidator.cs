using FluentValidation;
using MyBlog.Dtos.Dtos.ArticleDtos;

namespace MyBlog.Service.ValidationRules.ArticleValidators
{
    public class CreateArticleDtoValidator : AbstractValidator<CreateArticleDto>
    {
        public CreateArticleDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().NotNull().WithMessage("Başlık Boş Geçilemez!").MaximumLength(300).WithMessage("Başlık 300 Karakterden Uzun Olamaz'");
            RuleFor(x => x.ContentSummary).NotEmpty().NotNull().WithMessage("Özet Boş Geçilemez!").MaximumLength(500).WithMessage("Özet 500 Karakterden Uzun Olamaz!");
            RuleFor(x => x.ContentMain).NotEmpty().NotNull().WithMessage("İçerik Boş Geçilemez!");
            RuleFor(x => x.CategoryId).NotEmpty().NotNull().WithMessage("Kategori Boş Geçilemez!");
        }
    }
}
