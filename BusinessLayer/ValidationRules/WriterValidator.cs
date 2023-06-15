using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Bırakamazsınız.");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Hakkında Boş Bırakamazsınız.");
            RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen 20 karakterden fazla girmeyiniz.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar Ünvanı Boş Bırakamazsınız.");
        }
    }
}
