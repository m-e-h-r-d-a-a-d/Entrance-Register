using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EntranceRegister.Models;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using EntranceRegister.Forms;

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

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .Build();

        var serviceProvider = new ServiceCollection()
            .AddDbContext<EntranceContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
            .BuildServiceProvider();
        
        using var dbContext = serviceProvider.GetRequiredService<EntranceContext>();

        if (new FormLogin(dbContext).ShowDialog() == DialogResult.OK)
        {
            if (Globals.GatewayExists)
            {
                Application.Run(new FormMain(dbContext, configuration));
            }
            else
            {
                Application.Run(new FormReport(dbContext));
            }
        }
        else
        {
            Application.Exit();
        }
    }
}
