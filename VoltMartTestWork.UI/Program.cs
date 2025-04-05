using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VoltMartTestWork.Data.Repositories;
using System.Configuration;
using System;
using VoltMartTestWork.Core.Interfaces.IRepositories;
using VoltMartTestWork.Data;
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
            // �������� ServiceCollection
            var services = new ServiceCollection();
            // ����������� ������������
            services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql("Host=localhost;Database=employeedb;Username=postgres;Password=postgres"));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<Main>();

            // �������� ServiceProvider
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                // ��������� ���������� ������� ����� �� ServiceProvider
                var form1 = serviceProvider.GetRequiredService<Main>();
                Application.Run(form1);
            }
        }

    }
}