using BookShop.Application.FluentValidations;
using BookShop.Domain.Model;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.StartUp
{
    public static class FluentValidationInjectionService
    {
        public static IServiceCollection FluentValidationService(this IServiceCollection services)
        {
            services.AddScoped<IValidator<User>, UserFluentValidation>();
            return services;
        }
    }
}
