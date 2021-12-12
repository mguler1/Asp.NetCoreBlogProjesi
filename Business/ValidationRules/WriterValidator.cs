using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterNameSurname).NotEmpty().WithMessage("Ad Soyad Boş Geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("EMail Adresi Boş Geçilemez"); 
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez"); 
            RuleFor(x => x.WriterNameSurname).MinimumLength(2).WithMessage("Ad Soyad Alanı En Az 2 Karakter Olmalıdır"); 
            RuleFor(x => x.WriterNameSurname).MaximumLength(50).WithMessage("Ad Soyad Alanı En Fazla 50 Karakter Olmalıdır"); 
        }
    }
}
