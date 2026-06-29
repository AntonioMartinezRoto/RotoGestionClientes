using Microsoft.EntityFrameworkCore;
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

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            AppServices = services.BuildServiceProvider();

            using var scope = AppServices.CreateScope();

            var context =
                scope.ServiceProvider
                     .GetRequiredService<ApplicationDbContext>();

            var idioma = context.ConfiguracionAplicacion
                                .AsNoTracking()
                                .Select(x => x.Idioma)
                                .FirstOrDefault() ?? "ES";

            LanguageService.SetLanguage(idioma);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Main());
        }
    }
}