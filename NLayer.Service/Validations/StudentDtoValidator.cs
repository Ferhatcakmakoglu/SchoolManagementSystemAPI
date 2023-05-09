using FluentValidation;
using NLayer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Validations
{
    public class StudentDtoValidator:AbstractValidator<StudentDto>
    {
        public StudentDtoValidator()
        {
            //for string prop
            RuleFor(x => x.Name).NotNull().WithMessage("Student's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.Surname).NotNull().WithMessage("Student's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.PhoneNumber).NotNull().WithMessage("Student's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.DateOfBirth).NotNull().WithMessage("Student's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.Gender).NotNull().WithMessage("Student's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.ClassBranch).NotNull().WithMessage("Student's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.ParentName).NotNull().WithMessage("Student's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.ParentSurname).NotNull().WithMessage("Student's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");
            RuleFor(x => x.ParentPhoneNumber).NotNull().WithMessage("Student's {PropertyName} is Required!").NotEmpty().WithMessage("{PropertyName} is Empty!");

            //For decimal prop
            RuleFor(x => x.Age).InclusiveBetween(1, int.MaxValue).WithMessage("Student's {PropertyName} must be greater 1");
            RuleFor(x => x.SchoolId).InclusiveBetween(1, int.MaxValue).WithMessage("Student's {PropertyName} must be greater 1");
            RuleFor(x => x.ClassLevel).InclusiveBetween(1, int.MaxValue).WithMessage("Student's {PropertyName} must be greater 1");

        }
    }
}
