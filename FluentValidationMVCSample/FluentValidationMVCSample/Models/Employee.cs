using FluentValidation.Attributes;
using FluentValidationMVCSample.Validation;

namespace FluentValidationMVCSample.Models
{
    [Validator(typeof(EmployeeValidator))]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
    }
}