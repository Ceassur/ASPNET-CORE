using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementUpdateValidation:AbstractValidator<AnnouncementUpdateDTO>
    {
        public AnnouncementUpdateValidation()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Bu Alanı Boş Geçmeyiniz")
                .MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Giriniz")
                .MaximumLength(50).WithMessage("Lütfen En Fazla 50 Karakter Giriniz");

            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen Bu Alanı Boş Geçmeyiniz")
                .MinimumLength(5).WithMessage("Lütfen En Az 5 Karakter Giriniz")
                .MaximumLength(500).WithMessage("Lütfen En Fazla 500 Karakter Giriniz");
        }
    }
}
