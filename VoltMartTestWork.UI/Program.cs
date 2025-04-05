using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VoltMartTestWork.Data.Repositories;
using System.Configuration;
using System;
using VoltMartTestWork.Core.Interfaces.IRepositories;
using VoltMartTestWork.Data;
using VoltMartTestWork.Core.Interfaces.IServices;
using VoltMartTestWork.Core.Services;
namespace VoltMartTestWork.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Создание ServiceCollection
            var services = new ServiceCollection();
            // Регистрация зависимостей
            services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql("Host=localhost;Database=employeedb;Username=postgres;Password=postgres"));
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<Main>();

            //region Repositories
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();

            // Создание ServiceProvider
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                // Получение экземпляра главной формы из ServiceProvider
                var main = serviceProvider.GetRequiredService<Main>();
                Application.Run(main);
            }
        }

    }
}