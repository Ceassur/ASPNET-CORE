using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDTO>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez").
                MaximumLength(100).WithMessage("Konu alanı en fazla 100 karakterden daha fazla olamaz").
                MinimumLength(5).WithMessage("Konu alanı Ez az 5 karakter olmalı");

            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez").
               MaximumLength(30).WithMessage("İsim alanı en fazla 30 karakterden daha fazla olamaz").
               MinimumLength(5).WithMessage("İsim alanı Ez az 5 karakter olmalı");

            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj alanı boş geçilemez").
               MaximumLength(500).WithMessage("Mesaj alanı en fazla 500 karakterden daha fazla olamaz").
               MinimumLength(5).WithMessage("Mesaj alanı Ez az 5 karakter olmalı");
            
        }
    }
}
