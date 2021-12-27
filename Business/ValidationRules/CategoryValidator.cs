using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("İçerik boş geçilemez");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("En fazla 50 karakter olmalıdır");
            
        }
    }
}
