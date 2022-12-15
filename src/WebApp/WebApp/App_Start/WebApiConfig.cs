using FluentValidation.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApp.Filters;
using WebApp.DependencyResolution.Validation;

namespace WebApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filters.Add(new ValidateFilterAttribute());

            FluentValidationModelValidatorProvider.Configure(config, cfg =>
                {
                    cfg.ValidatorFactory = new MyValidatorFactory();
                });
        }
    }
}
