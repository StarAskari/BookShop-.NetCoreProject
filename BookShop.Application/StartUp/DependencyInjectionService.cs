using BookShop.Application.Interfaces;
using BookShop.Application.Services;
using BookShop.Infrastructure;
using BookShop.Infrastructure.Iterfaces;
using BookShop.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application.StartUp
{
    public static class DependencyInjectionService
    {
        public static  IServiceCollection RegisterInjectionServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
