using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alic1 adresini bos gecemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu bos gecemezsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj1 bos gecemezsimiz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girisi yapin");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 100 karakterden fazla deger girisi yapmayin");
        }
    }
}
