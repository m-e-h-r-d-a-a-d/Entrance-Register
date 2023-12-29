using System.Configuration;
using EntranceRegister.Models;

namespace EntranceRegister;

public static class Globals
{
    public static Gate? Gate { get; set; }
    public static bool GatewayExists => ConfigurationManager.AppSettings["GateId"] != null;

    public static User User { get; set; }

}
