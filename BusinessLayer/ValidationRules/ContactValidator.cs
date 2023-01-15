using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactName).NotEmpty().WithMessage("Lütfen adınızı yazınız. ");
            RuleFor(x => x.ContactSurname).NotEmpty().WithMessage("Lütfen soyadınızı yazınız. ");
            RuleFor(x=> x.ContactAddress ).NotEmpty().WithMessage("Lütfen adresinizi yazınız.");
            RuleFor(x => x.ContactMail).NotEmpty().WithMessage("Lütfen mail adresinizi yazınız.");
            RuleFor(x => x.ContactPhone).NotEmpty().WithMessage("Lütfen telefon numarasınızı yazınız. ");
            RuleFor(x => x.ContactDescription).NotEmpty().WithMessage("Lütfen açıklama kısmını yazınız. ");
            
        }
    }
}
