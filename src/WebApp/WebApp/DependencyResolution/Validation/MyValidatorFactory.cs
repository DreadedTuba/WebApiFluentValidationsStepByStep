using FluentValidation;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.App_Start;

namespace WebApp.DependencyResolution.Validation
{
    //public class MyValidatorFactory : IValidatorFactory
    //{
    //    public IValidator<T> GetValidator<T>()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IValidator GetValidator(Type type)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class MyValidatorFactory : ValidatorFactoryBase
    {
        public override IValidator CreateInstance(Type validatorType)
        {
            //return ObjectFactory.TryGetInstance(validatorType) as IValidator;
            return StructuremapMvc.StructureMapDependencyScope.CurrentNestedContainer.TryGetInstance(validatorType) as IValidator;
        }
    }
}