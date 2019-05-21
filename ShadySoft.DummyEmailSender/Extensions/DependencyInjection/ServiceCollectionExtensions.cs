using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShadySoft.DummyEmailSender.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDummyEmailSender(this IServiceCollection services)
        {
            return services.AddScoped<IEmailSender, DummyEmailSender>();
        }
    }
}
