using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using API.Services;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Interface;
using AutoMapper;
using API.Helpers;


namespace API.Extentions
{
    public static class ApplicationServiceExtentions
    {
        // public static IServiceCollection AddScoped<ITokenService, TokenService>(this IServiceCollection services)
        //     where ITokenService : class
        //     where TokenService : class, TService;
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));
            services.AddScoped<ITokenService,TokenService>();
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}