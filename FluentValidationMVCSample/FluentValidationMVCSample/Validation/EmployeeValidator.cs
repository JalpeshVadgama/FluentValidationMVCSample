using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidationMVCSample.Models;
using FluentValidation;

namespace FluentValidationMVCSample.Validation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FirstName).NotNull().WithMessage("Please enter first name");
            RuleFor(x => x.LastName).NotNull().WithMessage("Please ener last name");
        }
    }
}