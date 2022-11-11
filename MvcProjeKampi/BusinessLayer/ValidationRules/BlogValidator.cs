using System;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
   public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş  bırakmayınız");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş bırakmayınız");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Görselini Boş Geçemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("lütfen 150 karakterdan daha az girin");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("lütfen en az 5 karakter girin");

        }
     
          
    }
}
