using System;
using System.Runtime.Versioning;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OcrApp.Configuration;
using OcrApp.Forms;
using OcrApp.Services;

namespace OcrApp
{
    static class Program
    {
        public static IConfiguration Configuration { get; private set; } = null!;

        [STAThread]
        [SupportedOSPlatform("windows6.1")]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<MainWnd>();
            Application.Run(mainForm);
        }

        [SupportedOSPlatform("windows6.1")]
        private static void ConfigureServices(ServiceCollection services)
        {
            services.Configure<OcrOptions>(Configuration.GetSection(OcrOptions.SectionName));
            services.AddSingleton<IOcrService, OcrService>();
            services.AddTransient<MainWnd>();
        }
    }
}
