using EntranceRegister.Forms;
using EntranceRegister.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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

        // Process currentProcess = Process.GetCurrentProcess();
        // // Get the processor count
        // int processorCount = Environment.ProcessorCount;
        // currentProcess.ProcessorAffinity = (IntPtr)1; // Set to use the first CPU core


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
                Application.Run(new FormReport(dbContext, configuration));
            }
        }
        else
        {
            Application.Exit();
        }
    }
}
