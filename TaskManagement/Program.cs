using TaskManagement.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration.Json;
using TaskManagement.DataAccess.Interfaces;
using TaskManagement.DataAccess;
using TaskManagement.Repositories.Interface;
using TaskManagement.Repositories.Implementation;
using TaskManagement.Services.Interface;
using TaskManagement.Services.Implementation;
using TaskManagement.Controller;

namespace TaskManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IServiceProvider serviceProvider { get; private set; }
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var configuration=new ConfigurationBuilder()
                
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var services= new ServiceCollection();

           

            // made a method to set dependency injection of all interfaces nd implementation once
            ConfigureServices(services, configuration);

             serviceProvider= services.BuildServiceProvider();
            


            var loginForm=serviceProvider.GetRequiredService<LogInForm>();
            Application.Run(loginForm);
        }
        private static void ConfigureServices(IServiceCollection services,IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);
            services.AddScoped<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<IDataAccess, DBHelper>();
            services.AddScoped<ITaskRepo,TaskRepo>();
            services.AddScoped<IUserRepo,UserRepo>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<LogInController>();
            services.AddScoped<TaskController>();

            services.AddTransient<LogInForm>();
            services.AddTransient<EmployeeDash>();
            services.AddTransient<AdminDash>();
            services.AddTransient<AddForm>();
            services.AddTransient<EditForm>();
            services.AddTransient<SignUpForm>();
            services.AddTransient<ForgotPasswordForm>();
            services.AddTransient<EmpTaskForm>();
        }
    }
}