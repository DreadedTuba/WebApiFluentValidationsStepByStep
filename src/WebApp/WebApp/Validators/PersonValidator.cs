using FluentValidation;
using WebApp.Models;

namespace WebApp.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(a => a.Name).NotEmpty().MaximumLength(10);
        }
    }
}