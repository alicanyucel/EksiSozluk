using System;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("yazar ad ve soyadı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("şifre boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("lütfen yazar ismini en az 2 karakter giriniz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("yazar ismi 50 karakteri geçmemeli");
        }
    }
}
