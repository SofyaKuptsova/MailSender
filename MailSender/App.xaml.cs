using MailSender.Infrastructure;
using MailSender.lib.Interfaces;
using MailSender.Infrastructure.Services;
using MailSender.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace MailSender
{
    public partial class App
    {
        private static IHost _Hosting;

        public static IHost Hosting => _Hosting
            ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        public static IServiceProvider Services => Hosting.Services;

        public static IHostBuilder CreateHostBuilder(string[] args) => 
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(opt => opt.AddJsonFile("appsettings.json", false, true))
                .ConfigureServices(ConfigureServices)
            ;
        private static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<StatisticViewModel>();

            services.AddSingleton<ServersRepository>();
            services.AddSingleton<IStatistic, InMemoryStatisticService>();
        }
    }
}
