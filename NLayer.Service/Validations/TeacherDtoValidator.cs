using FluentValidation;
using NLayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validations
{
    public class TeacherDtoValidator : AbstractValidator<TeacherDto>
    {
        public TeacherDtoValidator()
        {
            //for string prop
            RuleFor(x => x.Name).NotNull().WithMessage("Teacher's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.Surname).NotNull().WithMessage("Teacher's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.PhoneNumber).NotNull().WithMessage("Teacher's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.DateOfBirth).NotNull().WithMessage("Teacher's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.Gender).NotNull().WithMessage("Teacher's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.Branch).NotNull().WithMessage("Teacher's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.BranchType).NotNull().WithMessage("Teacher's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");

            //For decimal prop
            RuleFor(x => x.Age).InclusiveBetween(1, int.MaxValue).WithMessage("Teacher's {PropertyName} must be greater 1");
            RuleFor(x => x.SchoolId).InclusiveBetween(1, int.MaxValue).WithMessage("Teacher's {PropertyName} must be greater 1");
        }
    }
}
