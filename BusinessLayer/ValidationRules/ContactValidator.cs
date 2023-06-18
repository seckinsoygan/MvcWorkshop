using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesajı boş bırakamazsınız.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş bırakamazsınız");
        }
    }
}
