using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using BehFarma.Model;

namespace EntranceRegister;

public static class Globals
{
    // public static Gate Gate { get; set; }
    public static bool GatewayExists
    {
        get { return ConfigurationManager.AppSettings["GateId"] != null; }
    }

    // public static User User { get; set; }

}