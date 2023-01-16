using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    //Validator geçerliliğinin sağlandığı class
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.WebSites).NotEmpty().WithMessage("WebSite kısmını boş geçmeyiniz.");
            RuleFor(x => x.AboutDescription).NotEmpty().WithMessage("Açıklama kısmını boş geçmeyiniz.");
            RuleFor(x => x.AboutDescription2).NotEmpty().WithMessage("Açıklama kısmını boş geçmeyiniz.");
            RuleFor(x => x.AboutTitle2).NotEmpty().WithMessage("Açıklama kısmını boş geçmeyiniz.");

        }
    }
}
