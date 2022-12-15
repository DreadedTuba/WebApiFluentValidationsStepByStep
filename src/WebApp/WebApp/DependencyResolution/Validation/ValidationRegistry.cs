using FluentValidation;
using StructureMap.Configuration.DSL;
using WebApp.Models;
using WebApp.Validators;

namespace WebApp.DependencyResolution.Validation
{
    public class ValidationRegistry : Registry
    {
        public ValidationRegistry()
        {
            For<IValidator<Person>>()
                .Singleton()
                .Use<PersonValidator>();
        }
    }
}