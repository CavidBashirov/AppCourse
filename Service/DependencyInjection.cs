﻿using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using FluentValidation;
using Service.DTOs.Admin.Countries;
using Service.Helpers;
using Service.Services.Interfaces;
using Service.Services;
using Service.DTOs.Account;

namespace Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile).Assembly);

            services.AddFluentValidationAutoValidation(config =>
            {
                config.DisableDataAnnotationsValidation = true;
            });

            services.AddScoped<IValidator<CountryCreateDto>, CountryCreateDtoValidator>();
            services.AddScoped<IValidator<RegisterDto>, RegisterDtoValidator>();

            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IEducationService, EducationService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IAuthorService, AuthorService>();
            

            return services;
        }
    }
}
