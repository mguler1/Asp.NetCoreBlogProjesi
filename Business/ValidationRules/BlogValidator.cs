using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
   public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("İçerik boş geçilemez");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Resim boş geçilemez");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("En Fazla 150 Karakter Girişi Yapabilirsiniz");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("En Az 5 Karakter Girişi Yapmalısınz");
        }
    }
}
