using Microsoft.Extensions.DependencyInjection;
using VoltMartTestWork.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VoltMartTestWork.Data;
using VoltMartTestWork.Data.Repositories;
using System.Configuration;
using System;
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

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<Main>();

            // Создание ServiceProvider
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                // Получение экземпляра главной формы из ServiceProvider
                var form1 = serviceProvider.GetRequiredService<Main>();
                Application.Run(form1);
            }
        }

    }
}