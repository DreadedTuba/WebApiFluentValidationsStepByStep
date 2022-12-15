using FluentValidation;
using StructureMap.Configuration.DSL;
using System.Reflection;
using WebApp.Models;
using WebApp.Validators;

namespace WebApp.DependencyResolution.Validation
{
    public class ValidationRegistry : Registry
    {
        public ValidationRegistry()
        {
            AssemblyScanner.FindValidatorsInAssembly(Assembly.GetExecutingAssembly())
                .ForEach(result =>
                {
                    For(result.InterfaceType)
                        .Singleton() // why?
                        .Use(result.ValidatorType);
                });
        }
    }
}