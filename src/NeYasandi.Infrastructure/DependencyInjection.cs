using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NeYasandi.Application.Interfaces;
using NeYasandi.Infrastructure.BackgroundJobs;
using NeYasandi.Infrastructure.Persistence;
using NeYasandi.Infrastructure.Services;


namespace NeYasandi.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(config.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IRssFeedParser, RssFeedParser>();
            services.AddScoped<RssFetchJob>();

            services.AddMassTransit(x =>
            {
                x.UsingRabbitMq((ctx, cfg) =>
                {
                    cfg.Host(config["RabbitMQ:Host"], "/", h =>
                    {
                        h.Username(config["RabbitMQ:UserName"]);
                        h.Password(config["RabbitMQ:Password"]);

                    });
                });
            });

            return services;


        }
    }
}
