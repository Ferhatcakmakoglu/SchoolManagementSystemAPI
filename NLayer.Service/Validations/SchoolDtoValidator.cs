using FluentValidation;
using NLayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validations
{
    public class SchoolDtoValidator : AbstractValidator<SchoolDto>
    {
        public SchoolDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("School's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.SchoolType).NotNull().WithMessage("{PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.Adress).NotNull().WithMessage("School's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.MailAdress).NotNull().WithMessage("School's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.PhoneNumber).NotNull().WithMessage("School's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
        }
    }
}
