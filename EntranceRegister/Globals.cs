using EntranceRegister.Models;
using Microsoft.Extensions.Configuration;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace EntranceRegister;

public static class Globals
{
    public static Gate? Gate { get; set; }
    public static bool GatewayExists
    {
        get
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            if (configuration["GlobalSettings:GateId"] != null) return true;
            return false;
        }
    }

    public static User User { get; set; }

}
