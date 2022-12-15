using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(a => a.Street).NotEmpty().MaximumLength(33);
            RuleFor(a => a.City).NotEmpty().MaximumLength(22);
            RuleFor(a => a.State).NotEmpty().MaximumLength(11);
            RuleFor(a => a.PostalCode).NotEmpty().Length(5);
        }
    }
}