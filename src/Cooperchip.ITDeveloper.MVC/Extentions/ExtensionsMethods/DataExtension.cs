using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.MVC.Extentions.ExtensionsMethods
{
    public static class DataExtension
    {
        public static string ToBrasilianDate(this DateTime valor)
        {
            return valor.ToString("dd/MM/yyyy");
        }
        public static string ToBrasilianDateTime(this DateTime valor)
        {
            return valor.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
