using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RotoGestionClientes
{
    internal static class Program
    {
        public static IServiceProvider AppServices { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            AppServices = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Main());
        }
    }
}