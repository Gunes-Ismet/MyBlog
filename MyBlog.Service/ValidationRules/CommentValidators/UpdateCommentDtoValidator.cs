using FluentValidation;
using MyBlog.Dtos.Dtos.CommentDtos;

namespace MyBlog.Service.ValidationRules.CommentValidators
{
    public class UpdateCommentDtoValidator : AbstractValidator<UpdateCommentDto>
    {
        public UpdateCommentDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Ad Soyad Boş Geçilemez!").MaximumLength(50).WithMessage("Ad Soyad 50 Karakterden Uzun Olamaz!");
            RuleFor(x => x.ContentMain).NotNull().NotEmpty().WithMessage("Yorum Boş Geçilemez!").MaximumLength(500).WithMessage("Yorum 500 Karakterden Uzun Olamaz!");
        }
    }
}
