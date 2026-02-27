using TaskManagement.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using Microsoft.Extensions.Configuration.Json;


using TaskManagement.Apiservices;

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
            //var configuration=new ConfigurationBuilder()

            //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            //    .Build();

            var services = new ServiceCollection();

            services.AddHttpClient<APIauthService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7016/");
            });

            services.AddHttpClient<APITaskService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7016/");
            });

            // made a method to set dependency injection of all interfaces nd implementation once
            //ConfigureServices(services, configuration);

            services.AddTransient<LogInForm>();
            services.AddTransient<EmployeeDash>();
            services.AddTransient<AdminDash>();
            services.AddTransient<AddForm>();
            services.AddTransient<EditForm>();
            services.AddTransient<SignUpForm>();
            services.AddTransient<ForgotPasswordForm>();
            services.AddTransient<EmpTaskForm>();
            serviceProvider = services.BuildServiceProvider();



            var loginForm = serviceProvider.GetRequiredService<LogInForm>();
            Application.Run(loginForm);



        }
    }
}