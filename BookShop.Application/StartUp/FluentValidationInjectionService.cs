
using BookShop.Application.FluentValidations;
using BookShop.Domain.Model;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.StartUp
{
    public static class FluentValidationInjectionService
    {
        public static IServiceCollection FluentValidationService(this IServiceCollection services)
        {
            services.AddControllers().AddFluentValidation(fv => {
                fv.ImplicitlyValidateChildProperties = true;
                fv.ImplicitlyValidateRootCollectionElements = true;
                fv.RegisterValidatorsFromAssembly(Assembly.GetAssembly(typeof(UserFluentValidation)));
                });
            return services;
        }
    }
}
