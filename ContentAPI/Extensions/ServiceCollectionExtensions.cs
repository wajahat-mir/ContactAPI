using Content.Bll.Core.Interfaces;
using Content.Bll.Services;
using Content.Dal.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyInjections(this IServiceCollection services)
        {
            services.AddSingleton<IContactRepository, ContactRepository>();
            services.AddScoped<IContactService, ContactService>();
            return services;
        }
    }
}
