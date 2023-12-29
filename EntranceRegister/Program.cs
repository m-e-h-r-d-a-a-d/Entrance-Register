using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EntranceRegister.Models;
using Microsoft.Extensions.Configuration;

namespace EntranceRegister;

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


        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Load configuration
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        // Get the connection string
        var serviceProvider = new ServiceCollection()
            .AddDbContext<EntranceContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
            .BuildServiceProvider();

        // Get the DbContext from the service provider
        using var dbContext = serviceProvider.GetRequiredService<EntranceContext>();

        var formLogin = new FormLogin(dbContext);
        if (formLogin.ShowDialog() == DialogResult.OK)
        {
            // Globals.User = formLogin.User;
            if (Globals.GatewayExists)
                Application.Run(new FormMain(dbContext));
            else
                Application.Run(new FormReport(dbContext));
        }
        else
        {
            Application.Exit();
        }
    }
}
